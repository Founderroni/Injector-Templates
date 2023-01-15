using System;
using System.Windows.Forms;
using Transitions;

namespace NetheriteInjector
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SetUiVariables()
        {
            Exit.Left = 600;
            LabelVersion.Left = -300;
            Inject.Top = 400;
            FunniAnimation.Top = -100;

            Exit.Visible = true;
            LabelVersion.Visible = true;
            Inject.Visible = true;
            FunniAnimation.Visible = true;
        }
        private void Animate()
        {
            Transition ControlTransition = new Transition(new TransitionType_EaseInEaseOut(1400));
            ControlTransition.add(Exit, "Left", 528);
            ControlTransition.add(LabelVersion, "Left", 12);
            ControlTransition.add(Inject, "Top", 183);
            ControlTransition.add(FunniAnimation, "Top", 71);
            ControlTransition.run();
        }
        // It works, cope
        private void Main_Load(object sender, EventArgs e)
        {
            SetUiVariables();
            Animate();
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You gotta make this work", "Inject");
        }
    }
}
