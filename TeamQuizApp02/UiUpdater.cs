using System.Windows.Forms;

namespace TeamQuizApp02
{
    public class UiUpdater
    {
        // 問題文を表示するラベル
        private readonly Label _questionLabel;
        // 4つの回答ボタンをまとめて管理する配列
        private readonly Button[] _buttons;
        // 正解・不正解やスコアなどを表示するリストボックス
        private readonly ListBox _log;

        // コンストラクタ
        // Form1から問題文ラベル、回答ボタン、ログ用ListBoxを受け取る
        public UiUpdater(Label questionLabel, Button[] buttons, ListBox log)
        {
            _questionLabel = questionLabel;
            _buttons = buttons;
            _log = log;
        }

        // 問題と4つの選択肢を画面に表示する
        public void ShowQuestion(Question q)
        {

            // 問題文をラベルに表示

            _questionLabel.Text = q.Text;

            // 4つの回答ボタンに選択肢を設定
            for (int i = 0; i < 4; i++)
            {
                _buttons[i].Text = q.Choices[i];
            }
        }
        // 正解・不正解や現在のスコアなどをログに追加する
        public void LogResult(string msg)
        {
            _log.Items.Add(msg);
        }
    }
}
