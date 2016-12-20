namespace HomeworkDefiningClassesPart1
{
    
     public class Display
    {
        private ushort? width;
        private ushort? height;
        private uint? numberOfColors;

        public Display()
             : this(null, null, null)
        {
        }

        public Display(uint? numberOfColors)
            : this(numberOfColors, null, null)
        {
        }

        public Display(ushort? height, ushort? width)
            : this(null, height, width)
        {
        }

        
        public Display(uint? numberOfColors, ushort? height, ushort? width)
        {
            this.NumberOfColors = numberOfColors;
            this.Height = height;
            this.Width = width;
        }

        public ushort? Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        
        public ushort? Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

       
        public string Size
        {
            get { return string.Format("{0}x{1}", this.Height, this.Width); }
        }

        
        public uint? NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

        public override string ToString()
        {
            return string.Format("Width: {0}\nHeight: {1},Color: {2}",
                this.Width, this.Height, this.numberOfColors);
        }
    }
}