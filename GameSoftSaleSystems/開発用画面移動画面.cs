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
    public partial class 開発用画面移動画面 : Form
    {
        public 開発用画面移動画面()
        {
            InitializeComponent();
        }
        

        private void OpenForm(string formName)
        {
            Form frm = new Form();
            //引数より、開くフォームを設定
            switch (formName)
            {
                case "FormMainmenu":
                    frm = new FormMainmenu();
                    break;
                case "FormSetting":
                    frm = new FormSetting();
                    break;
                case "FormSubscription":
                    frm = new FormSubscription();
                    break;
            }

            //フォームを透明化
            Opacity = 0;

            //選択されたフォームを開く
            frm.ShowDialog();

            //開いたフォームから戻ってきたらメモリを解放する
            frm.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm("FormMainmenu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm("FormSetting");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm("FormSubscription");
        }
    }
}
