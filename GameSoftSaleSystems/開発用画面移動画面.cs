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
                case "FormTitleDetail":
                    frm = new FormTitleDetail();
                    break;
                case "FormTitleDetailRegist":
                    frm = new FormTitleDetailRegist();
                    break;
                case "FormTitleDetailUpdate":
                    frm = new FormTitleDetailUpdate();
                    break;
                case "FormViewAccounts":
                    frm = new FormViewAccounts();
                    break;
                case "FormInput":
                    frm = new FormInput();
                    break;
            }

            //フォームを透明化
            Opacity = 0;

            //選択されたフォームを開く
            frm.ShowDialog();

            //開いたフォームから戻ってきたらメモリを解放する
            frm.Dispose();
            Opacity = 1;
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

        private void button8_Click(object sender, EventArgs e)
        {

            FontDialog fd = new FontDialog();

            //初期のフォントを設定
            fd.Font = label2.Font;
            //初期の色を設定
            fd.Color = label2.ForeColor;
            //ユーザーが選択できるポイントサイズの最大値を設定する
            fd.MaxSize = 15;
            fd.MinSize = 10;
            //存在しないフォントやスタイルをユーザーが選択すると
            //エラーメッセージを表示する
            fd.FontMustExist = true;
            //横書きフォントだけを表示する
            fd.AllowVerticalFonts = false;
            //色を選択できるようにする
            fd.ShowColor = true;
            //取り消し線、下線、テキストの色などのオプションを指定可能にする
            //デフォルトがTrueのため必要はない
            fd.ShowEffects = true;
            //固定ピッチフォント以外も表示する
            //デフォルトがFalseのため必要はない
            fd.FixedPitchOnly = false;
            //ベクタ フォントを選択できるようにする
            //デフォルトがTrueのため必要はない
            fd.AllowVectorFonts = true;

            //ダイアログを表示する
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                //TextBox1のフォントと色を変える
                label2.Font = fd.Font;
                label2.ForeColor = fd.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm("FormTitleDetail");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm("FormTitleDetailRegist");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm("FormTitleDetailUpdate");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenForm("FormViewAccounts");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenForm("FormInput");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //DialogResult=new DialogResult
        }
    }
}
