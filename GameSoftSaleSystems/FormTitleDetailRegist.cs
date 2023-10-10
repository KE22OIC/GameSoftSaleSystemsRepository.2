using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoftSaleSystems
{
    public partial class FormTitleDetailRegist : Form
    {
        public FormTitleDetailRegist()
        {
            InitializeComponent();
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグされたファイルのパスを取得
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
            // 複数の場合、1個目の画像を表示
            pictureBox1.ImageLocation = fileName[0];
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
