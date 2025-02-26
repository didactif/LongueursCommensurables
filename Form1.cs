using System;
using System.Drawing;
using System.Windows.Forms;

namespace LongueursCommensurables
{
    public partial class Form1 : Form
    {
        private string largeLabel;
        private string smallLabel;
        private int divisions;
        private int largeRectangleWidth;
        private int smallRectangleWidth;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.panel1.Paint += new PaintEventHandler(this.Panel1_Paint);

            // Initialiser les champs avec des valeurs par défaut
            largeLabel = "A";
            smallLabel = "B";
            divisions = 1;

            // Configurer les TextBox pour une seule lettre
            textBoxLargeLabel.MaxLength = 1;
            textBoxSmallLabel.MaxLength = 1;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des TextBox sans les convertir en majuscules
            largeLabel = textBoxLargeLabel.Text;
            smallLabel = textBoxSmallLabel.Text;
            if (int.TryParse(textBoxDivisions.Text, out divisions) && divisions > 0)
            {
                // Calculer les largeurs des rectangles
                if (checkBoxRandomLength.Checked)
                {
                    // Longueur aléatoire entre 5 et 15 cm
                    largeRectangleWidth = random.Next(5, 16) * 10; // Convertir cm en pixels
                }
                else
                {
                    largeRectangleWidth = panel1.Width - 40; // Laisser de l'espace pour les marges
                }
                smallRectangleWidth = largeRectangleWidth / divisions;
                panel1.Invalidate(); // Redessiner le panel
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide pour les divisions.");
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int height = 50; // Hauteur commune des rectangles
            int yOffset = 100; // Position verticale pour les rectangles
            int arrowSize = 10; // Taille des flèches
            int labelMargin = 5; // Marge pour éviter de traverser les labels

            // Dessiner le grand rectangle
            g.DrawRectangle(Pens.Black, 10, yOffset, largeRectangleWidth, height);
            g.DrawString(largeLabel, new Font("Arial", 12), Brushes.Black, new PointF(largeRectangleWidth / 2 + 10 - 10, yOffset - 30));
            DrawArrow(g, 10, yOffset - 20 - labelMargin, 10 + largeRectangleWidth, yOffset - 20 - labelMargin, arrowSize);

            // Dessiner le petit rectangle
            g.DrawRectangle(Pens.Black, 10, yOffset + 60 + height, smallRectangleWidth, height);
            g.DrawString(smallLabel, new Font("Arial", 12), Brushes.Black, new PointF(smallRectangleWidth / 2 + 10 - 10, yOffset + 60 + height - 30));
            DrawArrow(g, 10, yOffset + 60 + height - 20 - labelMargin, 10 + smallRectangleWidth, yOffset + 60 + height - 20 - labelMargin, arrowSize);
        }

        private void DrawArrow(Graphics g, int x1, int y1, int x2, int y2, int arrowSize)
        {
            // Dessiner la ligne
            g.DrawLine(Pens.Black, x1, y1, x2, y2);

            // Calculer l'angle de la ligne
            double angle = Math.Atan2(y2 - y1, x2 - x1);

            // Dessiner les flèches aux extrémités
            PointF arrowLeft = new PointF(
                x1 + (float)(arrowSize * Math.Cos(angle + Math.PI / 4)),
                y1 + (float)(arrowSize * Math.Sin(angle + Math.PI / 4))
            );
            PointF arrowRight = new PointF(
                x1 + (float)(arrowSize * Math.Cos(angle - Math.PI / 4)),
                y1 + (float)(arrowSize * Math.Sin(angle - Math.PI / 4))
            );
            g.DrawLine(Pens.Black, x1, y1, arrowLeft.X, arrowLeft.Y);
            g.DrawLine(Pens.Black, x1, y1, arrowRight.X, arrowRight.Y);

            arrowLeft = new PointF(
                x2 - (float)(arrowSize * Math.Cos(angle + Math.PI / 4)),
                y2 - (float)(arrowSize * Math.Sin(angle + Math.PI / 4))
            );
            arrowRight = new PointF(
                x2 - (float)(arrowSize * Math.Cos(angle - Math.PI / 4)),
                y2 - (float)(arrowSize * Math.Sin(angle - Math.PI / 4))
            );
            g.DrawLine(Pens.Black, x2, y2, arrowLeft.X, arrowLeft.Y);
            g.DrawLine(Pens.Black, x2, y2, arrowRight.X, arrowRight.Y);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Effacer les zones de saisie
            textBoxLargeLabel.Clear();
            textBoxSmallLabel.Clear();
            textBoxDivisions.Clear();
            checkBoxRandomLength.Checked = false;

            // Réinitialiser les variables
            largeLabel = "";
            smallLabel = "";
            divisions = 0;
            largeRectangleWidth = 0;
            smallRectangleWidth = 0;

            // Redessiner le panel (ce qui effacera les rectangles)
            panel1.Invalidate();
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Afficher la fenêtre "À propos"
            MessageBox.Show("Groupe Didactique de l'Ires d'Aix-Marseille\nVersion 1.1", "À propos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
