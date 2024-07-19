using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DentalService
{
    public class CustomTextBox : TextBox
    {
        // Fields
        private string placeholderText = "";
        private Color placeholderColor = Color.Gray;
        private Color textColor = Color.Black;
        private bool isPlaceholderActive = true;

        // Properties
        [Category("Advance")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                SetPlaceholder();
            }
        }

        [Category("Advance")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholderActive)
                {
                    this.ForeColor = value;
                }
                this.Invalidate();
            }
        }

        [Category("Advance")]
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                if (!isPlaceholderActive)
                {
                    this.ForeColor = value;
                }
                this.Invalidate();
            }
        }

        // Constructor
        public CustomTextBox()
        {
            this.Enter += RemovePlaceholder;
            this.Leave += SetPlaceholder;
            SetPlaceholder();
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                isPlaceholderActive = false;
                this.Text = "";
                this.ForeColor = TextColor;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                isPlaceholderActive = true;
                this.Text = placeholderText;
                this.ForeColor = placeholderColor;
            }
        }

        private void SetPlaceholder()
        {
            if (this.DesignMode)
            {
                this.ForeColor = placeholderColor;
                this.Text = placeholderText;
            }
            else if (string.IsNullOrEmpty(this.Text) && !this.Focused)
            {
                this.ForeColor = placeholderColor;
                this.Text = placeholderText;
                isPlaceholderActive = true;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (!this.Focused && string.IsNullOrEmpty(this.Text))
            {
                SetPlaceholder(null, null);
            }
        }
    }
}
