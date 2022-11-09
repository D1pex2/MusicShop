using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicShop
{
    /// <summary>
    /// Кнопка, меняющая цвет при наведении
    /// </summary>
    public partial class BlinkButton : Button
    {
        /// <summary>
        /// Поле цвета кнопки при наведении
        /// </summary>
        private Color blinkColor;

        /// <summary>
        /// Свойство цвета кнопки при наведении
        /// </summary>
        public Color BlinkColor { get => blinkColor; set => blinkColor = value; }

        /// <summary>
        /// Поле для временного хранения цвета кнопки при наведении
        /// </summary>
        private Color tempColor;

        public BlinkButton()
        {
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            tempColor = BackColor;
            BackColor = BlinkColor;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BackColor = tempColor;
            base.OnMouseLeave(e);
        }
    }
}
