using System.Drawing;
using System.Windows.Forms;

namespace DotaStat
{
    public partial class Stat : Form
    {
        string name, description,role ,icon, items, skills;
        public Stat(int N)
        {
            
            InitializeComponent();
            this.N = N;
            Hero(N);
            BackColor = Color.FromArgb(31,43,54);
            Text = name;
            labelName.Text = name;
            pictureBoxIcon.Image = System.Drawing.Image.FromFile(icon);
            labelDesription.Text = description;
            labelRole.Text = role;
            pictureBoxItems.Image = System.Drawing.Image.FromFile(items);
            pictureBoxSkills.Image = System.Drawing.Image.FromFile(skills);

        }
        int N;
        public void Hero(int n)
        {
            
            switch(n)
            {
                case 1:
                    name = "Abaddon";
                    description = "Защищает союзников или себя самого";
                    icon = @"pictures\strenght\Abaddon.jpg";
                    items = @"pictures\builds\abaddon_items.png";
                    skills = @"pictures\builds\abaddon_skills.png";
                    role = "Carry, Durable, Support";

                    break;
                case 2:

                    name = "Anti-Mage";
                    description = "Выжигает ману врагов атаками";
                    icon = @"pictures\agility\Anti-Mage.jpg";
                    items = @"pictures\builds\anti-mage_items.png";
                    skills = @"pictures\builds\anti-mage_skills.png";
                    role = "Carry, Escape, Nuker";
                    break;
                case 3:
                    name = "Ancient Apparition";
                    description = "Запускает мощный ледяной шар в любую точку карты";
                    icon = @"pictures\intelegence\Ancient_Apparition.jpg";
                    items = @"pictures\builds\ancient_apparation_items.png";
                    skills = @"pictures\builds\ancient_apparation_skills.png";
                    role = "Disabler, Nuker, Support";
                    break;
                default:
                    name = "Error";
                    break;
            }
        }
        

    }
}
