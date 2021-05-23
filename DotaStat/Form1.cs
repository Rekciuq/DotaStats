using System;
using System.Drawing;
using System.Windows.Forms;

namespace DotaStat
{
    public partial class Form1 : Form
    {
        bool strength, agility, intelligence;
        int n;

        private void buttonAgility_Click(object sender, EventArgs e)
        {
            agility = true;
            strength = false;
            intelligence = false;
            HeroGrid();
        }

        private void buttonIntelligence_Click(object sender, EventArgs e)
        {
            intelligence = true;
            strength = false;
            agility = false;
            HeroGrid();
        }

        public Form1()
        {
            InitializeComponent();

            //Визуальаняя часть
            //----------------------------------------------------------
            label1.BackColor = Color.FromArgb(0, 0, 0,0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBoxBack.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBoxStr.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBoxAgi.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBoxInt.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox10.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox11.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox12.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox13.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox14.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox15.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox16.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox17.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox18.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox19.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox20.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox21.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox22.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox23.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox24.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox25.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox26.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox27.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox28.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox29.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox30.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox31.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox32.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox33.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox34.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox35.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox36.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox37.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox38.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox39.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox40.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox41.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox42.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox43.BackColor = Color.FromArgb(0, 0, 0, 0);
            //----------------------------------------------------------
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (strength)
            {
                n = 1;
            }
            else if (agility)
            {
                n = 2;
            }
            else if (intelligence)
            {
                n = 3;
            }
            Form stat = new Stat(n);
            stat.Show();
            
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Width = 210;
            Height = 272;
            label1.Visible = true;
            label2.Visible = true;
            buttonStrength.Visible = true;
            buttonAgility.Visible = true;
            buttonIntelligence.Visible = true;
            pictureBoxStr.Visible = true;
            pictureBoxAgi.Visible = true;
            pictureBoxInt.Visible = true;
            pictureBoxBack.Visible = false;

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            pictureBox19.Image = null;
            pictureBox20.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox24.Image = null;
            pictureBox25.Image = null;
            pictureBox26.Image = null;
            pictureBox27.Image = null;
            pictureBox28.Image = null;
            pictureBox29.Image = null;
            pictureBox30.Image = null;
            pictureBox31.Image = null;
            pictureBox32.Image = null;
            pictureBox33.Image = null;
            pictureBox34.Image = null;
            pictureBox35.Image = null;
            pictureBox36.Image = null;
            pictureBox37.Image = null;
            pictureBox38.Image = null;
            pictureBox39.Image = null;
            pictureBox40.Image = null;
            pictureBox41.Image = null;
            pictureBox42.Image = null;
            pictureBox43.Image = null;


            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;


        }

        private void buttonStrength_Click(object sender, EventArgs e)
        {
            strength = true;
            agility = false;
            intelligence = false;
            HeroGrid();
        }

        public void HeroGrid()
        {
            Width = 652;
            Height = 504;
            label1.Visible = false;
            label2.Visible = false;
            buttonStrength.Visible = false;
            buttonAgility.Visible = false;
            buttonIntelligence.Visible = false;
            pictureBoxStr.Visible = false;
            pictureBoxAgi.Visible = false;
            pictureBoxInt.Visible = false;
            pictureBoxBack.Visible = true;




            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
            pictureBox21.Visible = true;
            pictureBox22.Visible = true;
            pictureBox23.Visible = true;
            pictureBox24.Visible = true;
            pictureBox25.Visible = true;
            pictureBox26.Visible = true;
            pictureBox27.Visible = true;
            pictureBox28.Visible = true;
            pictureBox29.Visible = true;
            pictureBox30.Visible = true;
            pictureBox31.Visible = true;
            pictureBox32.Visible = true;
            pictureBox33.Visible = true;
            pictureBox34.Visible = true;
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            pictureBox37.Visible = true;
            pictureBox38.Visible = true;
            pictureBox39.Visible = true;
            pictureBox40.Visible = true;
            pictureBox41.Visible = true;
            pictureBox42.Visible = true;
            pictureBox43.Visible = true;

            if (strength)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Abaddon.jpg");
                pictureBox2.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Alchemist_icon.jpg");
                pictureBox3.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Axe_icon.jpg");
                pictureBox4.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Beastmaster_icon.jpg");
                pictureBox5.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Brewmaster_icon.jpg");
                pictureBox6.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Bristleback_icon.jpg");
                pictureBox7.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Centaur_Warrunner_icon.jpg");
                pictureBox8.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Chaos_Knight_icon.jpg");
                pictureBox9.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Clockwerk_icon.jpg");
                pictureBox10.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Dawnbreaker_icon.jpg");
                pictureBox11.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Doom_icon.jpg");
                pictureBox12.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Dragon_Knight_icon.jpg");
                pictureBox13.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Earth_Spirit_icon.jpg");
                pictureBox14.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Earthshaker_icon.jpg");
                pictureBox15.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Elder_Titan_icon.jpg");
                pictureBox16.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Huskar_icon.jpg");
                pictureBox17.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Io_icon.jpg");
                pictureBox18.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Kunkka_icon.jpg");
                pictureBox19.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Legion_Commander_icon.jpg");
                pictureBox20.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Lifestealer_icon.jpg");
                pictureBox21.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Lycan_icon.jpg");
                pictureBox22.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Magnus_icon.jpg");
                pictureBox23.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Mars_icon.jpg");
                pictureBox24.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Night_Stalker_icon.jpg");
                pictureBox25.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Omniknight_icon.jpg");
                pictureBox26.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Phoenix_icon.jpg");
                pictureBox27.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Pudge_icon.jpg");
                pictureBox28.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Sand_King_icon.jpg");
                pictureBox29.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Slardar_icon.jpg");
                pictureBox30.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Snapfire_icon.jpg");
                pictureBox31.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Spirit_Breaker_icon.jpg");
                pictureBox32.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Sven_icon.jpg");
                pictureBox33.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Tidehunter_icon.jpg");
                pictureBox34.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Timbersaw_icon.jpg");
                pictureBox35.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Tiny_icon.jpg");
                pictureBox36.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Treant_Protector_icon.jpg");
                pictureBox37.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Tusk_icon.jpg");
                pictureBox38.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Underlord_icon.jpg");
                pictureBox39.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Undying_icon.jpg");
                pictureBox40.Image = System.Drawing.Image.FromFile(@"pictures\strenght\Wraith_King_icon.jpg");
                pictureBox41.Image = null;
                pictureBox42.Image = null;
                pictureBox43.Image = null;

            }
            else if (agility)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(@"pictures\agility\Anti-mage.jpg");
                pictureBox2.Image = System.Drawing.Image.FromFile(@"pictures\agility\Arc_Warden_icon.jpg");
                pictureBox3.Image = System.Drawing.Image.FromFile(@"pictures\agility\Bloodseeker_icon.jpg");
                pictureBox4.Image = System.Drawing.Image.FromFile(@"pictures\agility\Bounty_Hunter_icon.jpg");
                pictureBox5.Image = System.Drawing.Image.FromFile(@"pictures\agility\Broodmother_icon.jpg");
                pictureBox6.Image = System.Drawing.Image.FromFile(@"pictures\agility\Clinkz_icon.jpg");
                pictureBox7.Image = System.Drawing.Image.FromFile(@"pictures\agility\Drow_Ranger_icon.jpg");
                pictureBox8.Image = System.Drawing.Image.FromFile(@"pictures\agility\Ember_Spirit_icon.jpg");
                pictureBox9.Image = System.Drawing.Image.FromFile(@"pictures\agility\Faceless_Void_icon.jpg");
                pictureBox10.Image = System.Drawing.Image.FromFile(@"pictures\agility\Gyrocopter_icon.jpg");
                pictureBox11.Image = System.Drawing.Image.FromFile(@"pictures\agility\Hoodwink_icon.jpg");
                pictureBox12.Image = System.Drawing.Image.FromFile(@"pictures\agility\Juggernaut_icon.jpg");
                pictureBox13.Image = System.Drawing.Image.FromFile(@"pictures\agility\Lone_Druid_icon.jpg");
                pictureBox14.Image = System.Drawing.Image.FromFile(@"pictures\agility\Luna_icon.jpg");
                pictureBox15.Image = System.Drawing.Image.FromFile(@"pictures\agility\Medusa_icon.jpg");
                pictureBox16.Image = System.Drawing.Image.FromFile(@"pictures\agility\Meepo_icon.jpg");
                pictureBox17.Image = System.Drawing.Image.FromFile(@"pictures\agility\Mirana_icon.jpg");
                pictureBox18.Image = System.Drawing.Image.FromFile(@"pictures\agility\Monkey_King_icon.jpg");
                pictureBox19.Image = System.Drawing.Image.FromFile(@"pictures\agility\Morphling_icon.jpg");
                pictureBox20.Image = System.Drawing.Image.FromFile(@"pictures\agility\Naga_Siren_icon.jpg");
                pictureBox21.Image = System.Drawing.Image.FromFile(@"pictures\agility\Nyx_Assassin_icon.jpg");
                pictureBox22.Image = System.Drawing.Image.FromFile(@"pictures\agility\Pangolier_icon.jpg");
                pictureBox23.Image = System.Drawing.Image.FromFile(@"pictures\agility\Phantom_Assassin_icon.jpg");
                pictureBox24.Image = System.Drawing.Image.FromFile(@"pictures\agility\Phantom_Lancer_icon.jpg");
                pictureBox25.Image = System.Drawing.Image.FromFile(@"pictures\agility\Razor_icon.jpg");
                pictureBox26.Image = System.Drawing.Image.FromFile(@"pictures\agility\Riki_icon.jpg");
                pictureBox27.Image = System.Drawing.Image.FromFile(@"pictures\agility\Shadow_Fiend_icon.jpg");
                pictureBox28.Image = System.Drawing.Image.FromFile(@"pictures\agility\Slark_icon.jpg");
                pictureBox29.Image = System.Drawing.Image.FromFile(@"pictures\agility\Sniper_icon.jpg");
                pictureBox30.Image = System.Drawing.Image.FromFile(@"pictures\agility\Spectre_icon.jpg");
                pictureBox31.Image = System.Drawing.Image.FromFile(@"pictures\agility\Templar_Assassin_icon.jpg");
                pictureBox32.Image = System.Drawing.Image.FromFile(@"pictures\agility\Terrorblade_icon.jpg");
                pictureBox33.Image = System.Drawing.Image.FromFile(@"pictures\agility\Troll_Warlord_icon.jpg");
                pictureBox34.Image = System.Drawing.Image.FromFile(@"pictures\agility\Ursa_icon.jpg");
                pictureBox35.Image = System.Drawing.Image.FromFile(@"pictures\agility\Vengeful_Spirit_icon.jpg");
                pictureBox36.Image = System.Drawing.Image.FromFile(@"pictures\agility\Venomancer_icon.jpg");
                pictureBox37.Image = System.Drawing.Image.FromFile(@"pictures\agility\Viper_icon.jpg");
                pictureBox38.Image = System.Drawing.Image.FromFile(@"pictures\agility\Weaver_icon.jpg");
                pictureBox39.Image = null;
                pictureBox40.Image = null;
                pictureBox41.Image = null;
                pictureBox42.Image = null;
                pictureBox43.Image = null;



            }
            else if (intelligence)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Ancient_Apparition.jpg");
                pictureBox2.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Bane_icon.jpg");
                pictureBox3.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Batrider_icon.jpg");
                pictureBox4.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Chen_icon.jpg");
                pictureBox5.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Crystal_Maiden_icon.jpg");
                pictureBox6.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Dark_Seer_icon.jpg");
                pictureBox7.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Dark_Willow_icon.jpg");
                pictureBox8.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Dazzle_icon.jpg");
                pictureBox9.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Death_Prophet_icon.jpg");
                pictureBox10.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Disruptor_icon.jpg");
                pictureBox11.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Enchantress_icon.jpg");
                pictureBox12.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Enigma_icon.jpg");
                pictureBox13.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Grimstroke_icon.jpg");
                pictureBox14.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Invoker_icon.jpg");
                pictureBox15.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Jakiro_icon.jpg");
                pictureBox16.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Keeper_of_the_Light_icon.jpg");
                pictureBox17.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Leshrac_icon.jpg");
                pictureBox18.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Lich_icon.jpg");
                pictureBox19.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Lina_icon.jpg");
                pictureBox20.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Lion_icon.jpg");
                pictureBox21.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Natures_Prophet_icon.jpg");
                pictureBox22.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Necrophos_icon.jpg");
                pictureBox23.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Ogre_Magi_icon.jpg");
                pictureBox24.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Oracle_icon.jpg");
                pictureBox25.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Outworld_Destroyer_icon.jpg");
                pictureBox26.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Puck_icon.jpg");
                pictureBox27.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Pugna_icon.jpg");
                pictureBox28.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Queen_of_Pain_icon.jpg");
                pictureBox29.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Rubick_icon.jpg");
                pictureBox30.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Shadow_Demon_icon.jpg");
                pictureBox31.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Shadow_Shaman_icon.jpg");
                pictureBox32.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Silencer_icon.jpg");
                pictureBox33.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Skywrath_Mage_icon.jpg");
                pictureBox34.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Storm_Spirit_icon.jpg");
                pictureBox35.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Techies_icon.jpg");
                pictureBox36.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Tinker_icon.jpg");
                pictureBox37.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Visage_icon.jpg");
                pictureBox38.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Void_Spirit_icon.jpg");
                pictureBox39.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Warlock_icon.jpg");
                pictureBox40.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Windranger_icon.jpg");
                pictureBox41.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Winter_Wyvern_icon.jpg");
                pictureBox42.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Witch_Doctor_icon.jpg");
                pictureBox43.Image = System.Drawing.Image.FromFile(@"pictures\intelegence\Zeus_icon.jpg");
            }
            else
            {

            }

        }
    }
}
