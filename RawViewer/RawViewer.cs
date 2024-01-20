using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
namespace RawViewer;

public partial class RawViewer : Form
{
    byte[]? _data;
    int _depth;

    public RawViewer()
    {
        InitializeComponent();
        widthField.Maximum = int.MaxValue;
        rGBToolStripMenuItem.Checked = true;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        
        if (panel1.Size != Size.Empty && stretchToolStripMenuItem.Checked)
            widthField.Value = panel1.Width;
    }

    void UpdateImage()
    {
        if (_data is null)
            return;

        if (widthField.Value == 0)
        {
            widthField.Value = panel1.Width;
            return;
        }

        Bitmap bmp = new(pictureBox1.Width, (int)Math.Ceiling(_data.Length / (float)(_depth * pictureBox1.Width)));

        unsafe
        {
            var data = bmp.LockBits(new(Point.Empty, bmp.Size), ImageLockMode.WriteOnly, bmp.PixelFormat);

            try
            {
                for (var i = 0; i < data.Height; ++i)
                {
                    var row = (int*)(data.Scan0 + i * data.Stride);

                    for (var j = 0; j < data.Width; ++j)
                    {
                        var p = i * data.Width * _depth + j * _depth;

                        if (p + _depth - 1 >= _data.Length)
                            goto outer;

                        row[j] = (_depth switch
                        {
                            1 => Color.FromArgb(_data[p], _data[p], _data[p]),
                            3 => Color.FromArgb(_data[p], _data[p + 1], _data[p + 2]),
                            4 => Color.FromArgb(_data[p], _data[p + 1], _data[p + 2], _data[p + 3]),
                            _ => default
                        }).ToArgb();
                    }
                }
            outer:;
            }
            finally
            {
                bmp.UnlockBits(data);
            }
        }

        pictureBox1.Image?.Dispose();
        pictureBox1.Height = bmp.Height;
        pictureBox1.Image = bmp;
    }

    void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using OpenFileDialog d = new();

        if (d.ShowDialog() == DialogResult.OK)
        {
            _data = File.ReadAllBytes(d.FileName);
            saveToolStripMenuItem.Enabled = pictureBox1.Visible = true;
            Text = $"Raw Viewer - {d.FileName} ({_data.Length} bytes)";
            UpdateImage();
        }
    }

    void clearToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _data = null;
        saveToolStripMenuItem.Enabled = pictureBox1.Visible = false;
        pictureBox1.Image?.Dispose();
        pictureBox1.Image = null;
        Text = "Raw Viewer";
    }

    void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using SaveFileDialog d = new();

        if (d.ShowDialog() == DialogResult.OK)
            pictureBox1.Image.Save(d.FileName);
    }

    void ChangeDepth(object sender, EventArgs e)
    {
        if (sender is ToolStripMenuItem { Checked: true } senderItem)
        {
            foreach (ToolStripMenuItem item in depthToolStripMenuItem.DropDownItems)
                if (item != senderItem)
                    item.Checked = false;

            _depth = (int)senderItem.Tag;
            UpdateImage();
        }
    }

    void widthField_ValueChanged(object sender, EventArgs e)
    {
        var test = pictureBox1.Width != widthField.Value;
        pictureBox1.Width = (int)widthField.Value;

        if (test)
            UpdateImage();
    }
}