namespace LANTicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawChessBoard();
        }

        public void DrawChessBoard()
        {
            Button oldButton = new Button();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button()
                {
                    Width = Const.Button_Width,
                    Height = Const.Button_Height,
                    Location = new Point(oldButton.Location.X + Const.Button_Width, oldButton.Location.Y)
                };
                panelChess.Controls.Add(btn);
                oldButton = btn;
            }
        }

    }
}
