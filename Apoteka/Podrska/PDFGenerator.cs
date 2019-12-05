using Apoteka.EFKlase;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Apoteka.Podrska
{
    class PDFGenerator
    {
        private static Font font = FontFactory.GetFont(FontFactory.COURIER, 12, Font.UNDERLINE);
        private static Font font2 = FontFactory.GetFont(FontFactory.COURIER, 9, Font.BOLD);
        private static Font font3 = FontFactory.GetFont(FontFactory.COURIER, 9, Font.NORMAL);
        private static Font font4 = FontFactory.GetFont(FontFactory.COURIER, 12, Font.BOLD);
        private static Font font5 = FontFactory.GetFont(FontFactory.COURIER, 12, Font.BOLD);
        private static Font font6 = FontFactory.GetFont(FontFactory.COURIER, 12, Font.BOLD);

        public static void kreirajIzvjestajRacun(string putanja, List<racun> racuni, DateTime? datumOd, DateTime? datumDo, zaposleni kreirao, BackgroundWorker bgw)
        {
            BaseFont bfArialUniCode = null;
            try
            {
                Byte[] fb = Properties.Resources.calibril;
                bfArialUniCode = BaseFont.CreateFont("calibri.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED, BaseFont.CACHED, fb, null);
            }
            catch (Exception)
            {
                bgw.ReportProgress(100, "greska");
                return;
            }
            font = new Font(bfArialUniCode, 12, Font.NORMAL);
            font2 = new Font(bfArialUniCode, 11, Font.NORMAL);
            font3 = new Font(bfArialUniCode, 9, Font.NORMAL);
            font4 = new Font(bfArialUniCode, 12, Font.BOLD);
            font5 = new Font(bfArialUniCode, 14, Font.BOLD);
            font6 = new Font(bfArialUniCode, 9, Font.BOLD);

            FileStream fajl = File.Create(putanja);
            Document dokument = null;
            try
            {
                dokument = new Document(PageSize.A4);
                PdfWriter.GetInstance(dokument, fajl);
                dokument.Open();
                dokument.AddAuthor("Apoteka");
                dokument.AddCreator("Apoteka");
                dokument.AddCreationDate();
                dokument.AddTitle("Izvjestaj - racuni za odredjeni period");
                dokument.AddSubject("Izvjestaj - racuni za odredjeni period");

                Paragraph pdf = new Paragraph();
                PdfPTable tabelaZaglavlje = new PdfPTable(2);
                tabelaZaglavlje.WidthPercentage = 100f;
                tabelaZaglavlje.SetWidths(new int[] { 1, 2 });
                PdfPCell cell = new PdfPCell();
                Image slika = Image.GetInstance(Properties.Resources.apoteka_png, System.Drawing.Imaging.ImageFormat.Png);
                cell.PaddingTop = 25;
                slika.ScaleAbsolute(100f, 100f);
                cell.Border = Rectangle.NO_BORDER;
                cell.HorizontalAlignment = Element.ALIGN_MIDDLE;
                cell.VerticalAlignment = Element.ALIGN_CENTER;
                cell.AddElement(slika);
                cell.Rowspan = 2;
                tabelaZaglavlje.AddCell(cell);

                cell = new PdfPCell();
                cell.PaddingLeft = 25;
                cell.Border = Rectangle.NO_BORDER;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_TOP;
                Paragraph par = new Paragraph("APOTEKA\n", font5);
                Chunk chunk = null;
                chunk = new Chunk("Izvještaj: računi izdati u određenom periodu\n", font3);
                par.Add(chunk);
                cell.AddElement(par);
                par = new Paragraph("________________________________________\n", font3);

                DateTime datOd = DateTime.Today;
                if (datumOd != null)
                {
                    datOd = (DateTime)datumOd;
                }
                DateTime datDo = DateTime.Today;
                if (datumDo != null)
                {
                    datDo = (DateTime)datumDo;
                }
                if (datumOd == null && datumDo == null)
                {
                    chunk = new Chunk("Izvještaj sadrži sve izdate račune\n", font6);
                    par.Add(chunk);
                }
                else
                {
                    if (datumOd != null)
                    {
                        chunk = new Chunk("Izdati od: ",font6);
                        par.Add(chunk);
                        chunk = new Chunk(datOd.ToString("dd.MM.yyyy") + "\n",font3);
                        par.Add(chunk);
                    }
                    if (datumDo != null)
                    {
                        chunk = new Chunk("Izdati do: ",font6);
                        par.Add(chunk);
                        chunk = new Chunk( datDo.ToString("dd.MM.yyyy") + "\n",font3);
                        par.Add(chunk);
                    }
                }
                chunk = new Chunk("Datum kreiranja izvještaja: ",font6);
                par.Add(chunk);
                chunk = new Chunk(DateTime.Today.ToString("dd.MM.yyyy") + "\n",font3);
                par.Add(chunk);
                chunk = new Chunk("Izvještaj kreirao: ",font6);
                par.Add(chunk);
                chunk = new Chunk(kreirao.ime + " " + kreirao.prezime + "\n",font3);
                par.Add(chunk);
                chunk = new Chunk("Broj računa: ", font6);
                par.Add(chunk);
                chunk = new Chunk(racuni.Count + "\n",font3);
                par.Add(chunk);
                decimal ukupno = 0;
                foreach (racun rcn in racuni)
                {
                    ukupno += rcn.ukupanIznos;
                }
                chunk = new Chunk("Ukupan promet: ", font6);
                par.Add(chunk);
                chunk = new Chunk(ukupno.ToString() + "\n", font3);
                par.Add(chunk);
                cell.AddElement(par);
                par = new Paragraph("________________________________________\n", font3);
                cell.AddElement(par);
                tabelaZaglavlje.AddCell(cell);

                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;
                table.SpacingBefore = 10f;
                table.SpacingAfter = 10f;

                float[] columnWidths = { 0.3f, 0.8f, 1f, 0.6f };
                table.SetWidths(columnWidths);

                cell = new PdfPCell(new Paragraph("R.br.", font4));
                cell.PaddingLeft = 10;
                cell.BackgroundColor = new BaseColor(134, 216, 144);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;

                PdfPCell cell1 = new PdfPCell(new Paragraph("Datum izdavanja", font4));
                cell1.PaddingLeft = 10;
                cell1.BackgroundColor = new BaseColor(134, 216, 144);
                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                cell1.VerticalAlignment = Element.ALIGN_MIDDLE;

                PdfPCell cell2 = new PdfPCell(new Paragraph("Izdao", font4));
                cell2.PaddingLeft = 10;
                cell2.BackgroundColor = new BaseColor(134, 216, 144);
                cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                cell2.VerticalAlignment = Element.ALIGN_MIDDLE;

                PdfPCell cell3 = new PdfPCell(new Paragraph("Iznos računa", font4));
                cell3.PaddingLeft = 10;
                cell3.BackgroundColor = new BaseColor(134, 216, 144);
                cell3.HorizontalAlignment = Element.ALIGN_CENTER;
                cell3.VerticalAlignment = Element.ALIGN_MIDDLE;

                table.AddCell(cell);
                table.AddCell(cell1);
                table.AddCell(cell2);
                table.AddCell(cell3);
                int brojacUnosa = 1;

                int total = racuni.Count + 1;
                int indeks = 1;
                int percents = 0;
                using (ApotekaDb context = new ApotekaDb())
                {
                    for (int redniBrojUTabeli = 0; redniBrojUTabeli < racuni.Count;)
                    {
                        racun rac = racuni.ElementAt(redniBrojUTabeli);
                        if (brojacUnosa % 2 == 0)
                        {
                            List<stavkaracuna> stavke = new List<stavkaracuna>();
                            stavke = (from sr in context.stavkaracunas
                                      where sr.idRacuna == rac.idRacuna
                                      select sr).ToList();
                            cell = new PdfPCell(new Paragraph("", font6));
                            cell.PaddingLeft = 10;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell.Rowspan = stavke.Count + 1;

                            cell1 = new PdfPCell(new Paragraph("Lijek", font6));
                            cell1.PaddingLeft = 10;
                            cell1.BackgroundColor = new BaseColor(212, 252, 249);
                            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell1.VerticalAlignment = Element.ALIGN_MIDDLE;

                            cell2 = new PdfPCell(new Paragraph("Količina", font6));
                            cell2.PaddingLeft = 10;
                            cell2.BackgroundColor = new BaseColor(212, 252, 249);
                            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell2.VerticalAlignment = Element.ALIGN_MIDDLE;

                            cell3 = new PdfPCell(new Paragraph("Iznos stavke", font6));
                            cell3.PaddingLeft = 10;
                            cell3.BackgroundColor = new BaseColor(212, 252, 249);
                            cell3.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell3.VerticalAlignment = Element.ALIGN_MIDDLE;

                            table.AddCell(cell);
                            table.AddCell(cell1);
                            table.AddCell(cell2);
                            table.AddCell(cell3);

                            foreach (stavkaracuna sr in stavke)
                            {
                                lijek ljk = null;
                                ljk = (from l in context.lijeks
                                       where l.idLijeka == sr.idLijeka
                                       select l).FirstOrDefault();

                                if (ljk != null)
                                {
                                    cell1 = new PdfPCell(new Paragraph(ljk.naziv, font3));
                                }
                                else
                                {
                                    cell1 = new PdfPCell(new Paragraph("", font3));

                                }
                                cell1.PaddingLeft = 10;
                                cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell1.VerticalAlignment = Element.ALIGN_MIDDLE;

                                cell2 = new PdfPCell(new Paragraph(sr.kolicina.ToString(), font3));
                                cell2.PaddingLeft = 10;
                                cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell2.VerticalAlignment = Element.ALIGN_MIDDLE;

                                cell3 = new PdfPCell(new Paragraph(sr.iznos.ToString(), font3));
                                cell3.PaddingLeft = 10;
                                cell3.HorizontalAlignment = Element.ALIGN_RIGHT;
                                cell3.VerticalAlignment = Element.ALIGN_MIDDLE;
                                table.AddCell(cell1);
                                table.AddCell(cell2);
                                table.AddCell(cell3);
                            }
                            percents = (indeks * 100) / total;
                            bgw.ReportProgress(percents, "ok");
                            indeks++;
                            redniBrojUTabeli++;
                        }
                        else
                        {
                            cell = new PdfPCell(new Paragraph((redniBrojUTabeli+1) + ".", font));
                            cell.PaddingLeft = 10;
                            cell.BackgroundColor = new BaseColor(189, 252, 196);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell1 = new PdfPCell(new Paragraph(rac.datumKreiranja.ToString("dd.MM.yyyy"), font2));
                            cell1.PaddingLeft = 10;
                            cell1.BackgroundColor = new BaseColor(189, 252, 196);
                            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell1.VerticalAlignment = Element.ALIGN_MIDDLE;
                            
                            zaposleni zps = null;
                            zps = (from z in context.zaposlenis
                                   where z.idZaposlenog == rac.idZaposlenog
                                   select z).FirstOrDefault();

                            if (zps != null)
                            {
                                cell2 = new PdfPCell(new Paragraph(zps.ime + " " + zps.prezime, font2));
                            }
                            else
                            {
                                cell2 = new PdfPCell(new Paragraph("", font2));
                            }
                            cell2.PaddingLeft = 10;
                            cell2.BackgroundColor = new BaseColor(189, 252, 196);
                            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell3 = new PdfPCell(new Paragraph(rac.ukupanIznos.ToString(), font2));
                            cell3.PaddingLeft = 10;
                            cell3.BackgroundColor = new BaseColor(189, 252, 196);
                            cell3.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cell3.VerticalAlignment = Element.ALIGN_MIDDLE;
                            table.AddCell(cell);
                            table.AddCell(cell1);
                            table.AddCell(cell2);
                            table.AddCell(cell3);
                        }
                        brojacUnosa++;
                    }
                }
                pdf.Add(tabelaZaglavlje);
                dokument.Add(pdf);
                pdf = new Paragraph("\n");
                dokument.Add(pdf);
                pdf = new Paragraph();
                pdf.Add(table);
                dokument.Add(pdf);

                if (dokument != null)
                    dokument.Close();
                percents = (indeks * 100) / total;
                System.Diagnostics.Process.Start(putanja);
                bgw.ReportProgress(percents, "ok");
            }
            catch (Exception)
            {
                bgw.ReportProgress(100, "greska");
                return;
            }
        }
    }
}
