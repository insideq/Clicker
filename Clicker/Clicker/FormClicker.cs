namespace Clicker;

using System.Drawing;
using System.Windows.Forms;

public partial class FormClicker : Form
{
    public int count = 0;

    public FormClicker()
    {
        InitializeComponent();
        UpdateCounter();
    }

    public void UpdateCounter()
    {
        // Получаем ссылку на существующий PictureBox по имени, заданному в дизайнере (например, pictureBoxCount)
        PictureBox pictureBox = this.pictureBoxCount; // или Controls["pictureBoxCount"], если имя неизвестно

        if (pictureBox == null)
        {
            MessageBox.Show("Не найден PictureBox");
            return;
        }

        // Создаем новое изображение для PictureBox
        Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

        using (Graphics graphics = Graphics.FromImage(bitmap))
        {
            string text = count.ToString();

            using (Font font = new Font("Arial", 10))
            {
                SizeF textSize = graphics.MeasureString(text, font);
                float textX = (pictureBox.Width - textSize.Width) / 2; // Центр текста по горизонтали
                float textY = (pictureBox.Height - textSize.Height) / 2; // Центр текста по вертикали
                graphics.DrawString(text, font, Brushes.Black, textX, textY);
            }
        }

        // Новое изображение в PictureBox
        pictureBox.Image = bitmap;
    }

    private void buttonClick_Click(object sender, EventArgs e)
    {
        count++;
        UpdateCounter(); // Обновляем PictureBox при каждом клике
    }
}