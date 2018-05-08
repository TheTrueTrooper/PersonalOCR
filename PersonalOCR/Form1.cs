using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonalOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        const string La_PagerNumberQuick = "Page Number ";
        const string FileTypes = "PDF Files(*.PDF)| *.PDF| ALL Files(*.*)| *.*";

        List<string> _PagesText;

        int _PageCount;
        int _Page;


        private void BuLoadIn_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileFinder = new OpenFileDialog();
            FileFinder.Filter = FileTypes;

            if (FileFinder.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (PdfReader PDF = new PdfReader(FileFinder.FileName))
                    {
                        

                        _PagesText = new List<string>(PDF.NumberOfPages);
                        _PageCount = PDF.NumberOfPages;
                        for (int P = 0; P < PDF.NumberOfPages; P++)
                        {
                            
                            ITextExtractionStrategy ExtractionStrategy = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                            string PageText = PdfTextExtractor.GetTextFromPage(PDF, P + 1, ExtractionStrategy);
                            // Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(PageText));//why but keeping it for now
                            _PagesText.Add(PageText);
                        }

                        _Page = 0;
                        Bu_Prev.Enabled = false;

                        La_PageNumber.Text = La_PagerNumberQuick + 1;
                        if (_PageCount > 1)
                            Bu_Next.Enabled = true;
                        else
                            Bu_Next.Enabled = false;

                        RiTe_View.Text = _PagesText[_Page];
                    }
                }
                catch (Exception Exp)
                {
                    MessageBox.Show(Exp.Message);
                }

            }

        }

        private void Bu_Next_Click(object sender, EventArgs e)
        {
            if (_Page < _PageCount - 1)
            {
                _Page++;
                RiTe_View.Text = _PagesText[_Page];
                La_PageNumber.Text = La_PagerNumberQuick + (_Page + 1);
                Bu_Prev.Enabled = true;
                if (_Page == _PageCount - 1)
                {
                    Bu_Next.Enabled = false;
                }
            }
        }

        private void Bu_Prev_Click(object sender, EventArgs e)
        {
            if (_Page >= 0)
            {
                _Page--;
                RiTe_View.Text = _PagesText[_Page];
                La_PageNumber.Text = La_PagerNumberQuick + (_Page + 1);
                Bu_Next.Enabled = true;
                if (_Page == 0)
                {
                    Bu_Prev.Enabled = false;
                }
            }
        }

        private void Bu_FlipPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileFinder = new OpenFileDialog();
            FileFinder.Filter = FileTypes;

            if (FileFinder.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (PdfReader PDF = new PdfReader(FileFinder.FileName))
                    {
                        for (int P = 0; P < PDF.NumberOfPages; P++)
                        {
                            PDF.GetPageN(P + 1).Put(PdfName.ROTATE, new PdfNumber(180));

                        }

                        PdfStamper stamper = new PdfStamper(PDF, new FileStream(FileFinder.FileName.Insert(FileFinder.FileName.Length - 4, "_PDFFliped"), FileMode.Create));
                        stamper.Close();

                    }
                }
                catch (Exception Exp)
                {
                    MessageBox.Show(Exp.Message);
                }

            }
        }
    }

}

