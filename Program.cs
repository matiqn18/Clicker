using System;
using System.Windows.Forms;

public class ClickerGame : Form
{
    private int counter = 0;
    private Label label;
    private Button button;

    public ClickerGame()
    {
        label = new Label()
        {
            Text = "Counter: 0",
            Location = new System.Drawing.Point(10, 10),
            AutoSize = true
        };

        button = new Button()
        {
            Text = "Click me!",
            Location = new System.Drawing.Point(10, 40)
        };
        button.Click += new EventHandler(Button_Click);

        Controls.Add(label);
        Controls.Add(button);

        Text = "Clicker Game";
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
    }

    private void Button_Click(object sender, EventArgs e)
    {
        counter++;
        label.Text = "Counter: " + counter.ToString();
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new ClickerGame());
    }
}
