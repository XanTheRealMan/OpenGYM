/*
 * Copyright (C) 2025  Anas Yusuf <me@anasov.ly>.
 * 
 * This software is proprietary and is not free or open-source.
 * It is a paid software, and any use, distribution, or modification without a valid license is strictly prohibited.
 * Unauthorized use will result in legal action, including but not limited to lawsuits.  
 * 
 * For licensing inquiries, please contact the software owner.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using OpenGYM.Database;
using System.Reflection;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;
using System.Data.Common;
using QuestPDF;
using System.Configuration;


namespace OpenGYM
{
    internal class InvoiceBuilder
    {
        private Membership? _membership { get; set; } = null;
        private Payment? _payment { get; set; } = null;
        private int _customerID { get; set; } = -1;
        private string _customerName { get; set; } = string.Empty;
        private Document? _invoiceDocument { get; set; } = null;

        public InvoiceBuilder(Membership membership, Payment payment, int customerID, string customerName)
        {
            _membership = membership;
            _payment = payment;
            _customerID = customerID;
            _customerName = customerName;

            QuestPDF.Settings.License = LicenseType.Community;
        }

        public async void GenerateInvoice()
        {
            if (_membership == null || _payment == null || _customerID < 0 || string.IsNullOrEmpty(_customerName))
            {
                throw new InvalidOperationException("Invalid membership, payment, or customer details.");
            }

            var invoice = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.ContentFromRightToLeft(); // Set the page content direction to RTL
                    page.Margin(40);
                    page.DefaultTextStyle(x => x.FontSize(14).FontFamily("HONOR Sans Arabic UI").DirectionFromRightToLeft());

                    page.Header().Element(container =>
                    {
                        container.Column(col =>
                        {
                            // TODO: fix this
                            col.Item().Row(row =>
                            {
                                row.RelativeItem(2).Column(col =>
                                {
                                    col.Item().Text(Properties.Settings.Default.GymName).FontSize(14).Bold();
                                    col.Item().Text(Properties.Settings.Default.GymDirection).FontSize(12);
                                    //col.Item().Text(invoiceTitle.SettingValue).FontSize(14).Bold();
                                    //col.Item().Text(invoiceSubtitle.SettingValue).FontSize(12);
                                });

                                row.RelativeItem().Column(col =>
                                {
                                    col.Item().Text($"رقم الفاتورة").FontSize(14).Bold();
                                    col.Item().Text($"#{this._membership.MembershipID}").FontSize(12);
                                });

                                row.RelativeItem().Column(col =>
                                {
                                    col.Item().AlignLeft().Height(50).Svg("<svg width=\"357.94489\" height=\"401.97339\" viewBox=\"0 0 357.94489 401.97339\" version=\"1.1\" id=\"svg1\" xml:space=\"preserve\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:svg=\"http://www.w3.org/2000/svg\"><defs id=\"defs1\" /><g id=\"layer1\" transform=\"translate(-77.027565,-55.013306)\"><path style=\"fill:#aaaaaa;fill-opacity:1\" d=\"m 181.97296,455.72607 c -7.06304,-2.81641 -10.42306,-8.9392 -10.35894,-18.87654 0.0599,-9.28689 2.48439,-18.24861 10.81047,-39.95974 7.21294,-18.80848 8.23097,-22.22058 10.14583,-34.00559 l 1.37547,-8.46532 -5.23667,-4.42865 c -10.79202,-9.1268 -34.45709,-33.96927 -40.41508,-42.42583 -3.39812,-4.82318 -8.63798,-13.59464 -11.64414,-19.49214 -9.76279,-19.15271 -13.3376,-34.57754 -12.39527,-53.48385 0.82446,-16.54134 4.69081,-29.15759 13.46302,-43.93112 5.1336,-8.64563 18.62796,-24.80776 20.71292,-24.80776 0.99632,0 1.53747,2.35086 2.01418,8.75 1.30813,17.55943 5.80995,26.97466 24.02663,50.25 6.46056,8.25461 12.36567,17.08772 15.19792,22.73369 4.03754,8.04867 4.68988,10.23361 5.08303,17.02501 0.57741,9.9743 -1.37117,17.76446 -7.56434,30.2413 -6.10739,12.30403 -6.85781,12.45652 -16.34941,3.32246 -14.23743,-13.70113 -24.84723,-29.09826 -31.54441,-45.77778 -3.44899,-8.58982 -6.32173,-20.42801 -6.32173,-26.05104 0,-6.1948 -1.80331,-4.5884 -3.03296,2.70178 -5.97218,35.40712 28.9433,86.31789 85.53296,124.71684 25.75508,17.47612 61.5335,35.15984 82.5,40.77616 9.58176,2.56667 24.79916,2.30297 32.1471,-0.55708 7.86839,-3.06264 14.11554,-8.88811 18.00588,-16.79052 2.92017,-5.9317 3.26607,-7.61181 3.64358,-17.69736 0.49704,-13.27924 -1.40317,-22.64887 -7.73083,-38.1195 l -4.08031,-9.97604 3.48946,-3.48947 c 3.39434,-3.39434 3.52952,-3.43588 4.95851,-1.52396 2.65587,3.55343 12.34717,22.80761 15.5438,30.88163 7.74915,19.57275 10.94978,44.92551 7.64835,60.58388 -4.71852,22.37944 -16.45122,31.55342 -40.12554,31.37478 -27.38969,-0.20669 -63.16548,-14.83993 -106,-43.3568 -5.5,-3.6616 -10.53798,-6.97498 -11.19552,-7.36307 -0.75857,-0.44771 -2.73836,1.58799 -5.41678,5.56974 -2.32169,3.45144 -7.04498,9.29348 -10.4962,12.98231 -11.24008,12.01395 -17.3915,28.72745 -17.3915,47.253 0,12.58287 -1.45279,14.42586 -8.99948,11.41658 z m 126.99948,-64.83351 c -8.8607,-2.85885 -20.91023,-7.90543 -29.36422,-12.29832 l -7.86422,-4.08643 0.68999,-7.90996 c 0.86604,-9.92803 2.89063,-17.78894 6.09715,-23.67346 1.37108,-2.51617 9.04753,-13.57486 17.05877,-24.57486 8.01124,-11 15.02431,-20.85074 15.5846,-21.89052 0.75493,-1.401 -1.23758,-0.69025 -7.69497,2.74489 -15.742,8.37428 -31.69061,20.9947 -53.81333,42.58347 -13.06979,12.75434 -13.92326,13.4 -16,12.10422 -6.01043,-3.75019 -28.69377,-21.14332 -28.69377,-22.00181 0,-0.54204 2.29962,-6.28534 5.11027,-12.76289 15.23437,-35.10981 18.48931,-44.27155 22.48092,-63.27736 7.34674,-34.981 1.68035,-67.64763 -16.04232,-92.48373 -16.19084,-22.68943 -53.10756,-43.38664 -73.29887,-41.09473 -6.18238,0.70176 -6.70902,-0.32369 -1.5,-2.92076 5.50628,-2.74526 23.20294,-3.25389 34.32147,-0.98643 21.87824,4.46172 44.66546,15.66863 58.82559,28.93083 6.13083,5.74206 5.56322,3.95624 -1.7225,-5.41941 l -5.00411,-6.43955 2.02258,-4.04311 c 4.8315,-9.65814 12.26992,-14.54311 22.14501,-14.54311 9.25385,0 12.90361,1.95384 23.41196,12.53324 l 9.25,9.31255 v 10.89001 c 0,10.75685 -0.0361,10.92462 -2.95386,13.72 -8.43532,8.08155 -6.74202,16.5442 3.31034,16.5442 4.97942,0 17.7637,-6.86026 26.62466,-14.28724 19.40514,-16.2648 31.43812,-40.0525 29.64704,-58.60855 -0.35061,-3.63232 -0.91283,-7.841712 -1.2494,-9.354212 -1.14106,-5.12786 1.36376,-2.81669 5.41893,5.000002 10.80645,20.83037 10.26958,38.27233 -1.73887,56.49304 -4.58,6.94933 -8.10479,11.16543 -26.13178,31.25696 -10.19466,11.3622 -15.04458,19.48682 -18.80364,31.5 -1.63496,5.225 -4.40219,14.08697 -6.14941,19.69327 -1.74721,5.6063 -5.53429,14.89659 -8.41573,20.6451 l -5.23899,10.45182 6.59036,-2.53163 c 61.6469,-23.68112 88.42672,-22.4022 84.12678,4.01765 -1.7949,11.02827 -3.52275,13.20703 -39.03643,49.22379 -27.92936,28.325 -33.43729,34.41209 -36.37547,40.20034 -2.29243,4.51611 -2.06125,5.61693 1.62547,7.74011 12.17145,7.00952 24.75,17.44703 24.75,20.5372 0,1.5241 -5.77302,1.07447 -12,-0.93462 z M 121.37714,167.91092 c -10.70518,-4.34978 -40.536453,-18.87065 -42.595533,-20.73409 -2.13662,-1.93362 -2.35906,-6.19302 -0.45912,-8.79135 1.05023,-1.43628 2.15396,-1.71585 4.96995,-1.25887 6.53966,1.06124 44.246003,18.23389 50.034973,22.7875 3.30061,2.59625 3.36156,5.3098 0.19049,8.48087 -3.05899,3.05899 -3.46038,3.04299 -12.14076,-0.48406 z m 257.13807,0.39026 c -3.16297,-3.41291 -3.18823,-4.8971 -0.13528,-7.95005 4.06528,-4.06528 42.97431,-22.04019 50.27251,-23.22452 4.3284,-0.70241 6.32,1.30554 6.32,6.37189 0,4.10566 -1.49879,5.0098 -28.5,17.19257 -24.75726,11.17032 -24.67779,11.14868 -27.95723,7.61011 z M 138.47244,154.92253 c -8.83311,-3.27681 -55.849683,-25.07948 -57.706403,-26.75979 -2.04243,-1.84838 -2.3981,-7.30872 -0.5936,-9.11321 2.19739,-2.19739 7.04238,-1.24493 18.72447,3.68098 6.366543,2.68454 12.347013,5.13927 13.289933,5.45495 1.29276,0.43281 3.24625,-1.56695 7.94286,-8.13098 8.85935,-12.38193 25.30594,-28.424242 37.35469,-36.436473 26.58596,-17.679243 55.94322,-27.062299 88.98805,-28.442024 44.94665,-1.876661 88.10871,12.533429 121.73239,40.641585 8.22716,6.877602 19.45196,18.845812 28.41353,30.295352 l 2.14591,2.74168 10.72214,-4.58009 c 5.89718,-2.51906 13.18789,-5.0973 16.2016,-5.72943 5.03908,-1.05696 5.59576,-0.99045 6.92654,0.82756 1.82807,2.49738 0.95139,6.40968 -1.95273,8.71431 -5.94326,4.71641 -48.3234,23.74976 -59.51571,26.72912 -5.16267,1.37428 -7.17367,0.25706 -7.17367,-3.98539 0,-3.73956 5.18799,-8.17683 15.24842,-13.04194 4.3511,-2.10414 8.4377,-4.00151 9.08134,-4.21637 3.67765,-1.22769 -23.13394,-29.17228 -38.33686,-39.956892 -30.96979,-21.969271 -70.92828,-33.21661 -106.13422,-29.874194 -13.65169,1.296077 -26.51838,3.879886 -38.35868,7.702951 -11.66326,3.765904 -32.57719,14.426918 -43.49289,22.170793 -15.20394,10.786052 -42.01433,38.729712 -38.33686,39.957342 4.73304,1.58 17.65639,8.62505 20.66109,11.26321 4.14626,3.64047 4.85494,7.63041 1.83992,10.35896 -2.18854,1.9806 -1.53671,2.00372 -7.67126,-0.27201 z\" id=\"path1\" /></g></svg>");
                                });
                            });
                        });
                    });

                    page.Content().PaddingTop(20).Column(col =>
                    {
                        col.Spacing(10);

                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text($"إسم الرياضي : {this._customerName}").FontSize(10);
                            });
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().AlignLeft().Text($"تاريخ : {this._payment.CreatedAt:yyyy-MM-dd}").FontSize(10);
                            });
                        });

                        // Table with RTL headers and background
                        col.Item().PaddingTop(5).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(HeaderCellStyle).Text("نوع الإشتراك").Bold();
                                header.Cell().Element(HeaderCellStyle).Text("تاريخ البدء").Bold();
                                header.Cell().Element(HeaderCellStyle).Text("تاريخ الإنتهاء").Bold();
                                header.Cell().Element(HeaderCellStyle).Text("القيمة").Bold();
                            });

                            table.Cell().Element(CellStyle).Text(GetMembershipDurationText(this._membership.StartDate, this._membership.EndDate));
                            table.Cell().Element(CellStyle).Text(this._membership.StartDate.ToString("yyyy-MM-dd"));
                            table.Cell().Element(CellStyle).Text(this._membership.EndDate.ToString("yyyy-MM-dd"));
                            table.Cell().Element(CellStyle).Text($"{this._payment.Amount:F2} د.ل");
                        });

                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text($"الإجمالي: {this._payment.Amount:F2} د.ل").FontSize(14).Bold();
                            });

                            row.RelativeItem().Row(row =>
                            {
                                row.Spacing(10);

                                row.RelativeItem().Column(col =>
                                {
                                    col.Item().Text(Properties.Settings.Default.GymInvoiceNote1).FontSize(8);
                                    col.Item().Text(Properties.Settings.Default.GymInvoiceNote2).FontSize(8);
                                    //col.Item().Text("* يمنع سحب القيمة أو إيقاف الإشتراك").FontSize(8);
                                    //col.Item().Text("* الحذاء المخصص للنادي إجباري").FontSize(8);
                                });

                                row.RelativeItem().Column(col =>
                                {
                                    col.Item().Text(Properties.Settings.Default.GymInvoiceNote3).FontSize(8);
                                    col.Item().Text(Properties.Settings.Default.GymInvoiceNote4).FontSize(8);
                                    //col.Item().Text("* يمنع الجري على السير").FontSize(8);
                                    //col.Item().Text("* عدم إصطحاب الأطفال والاصدقاء").FontSize(8);
                                });
                            });
                        });
                    });
                });
            });
 
            this._invoiceDocument = invoice;
            // Set the invoice document
        }

        // Body cell style
        static IContainer CellStyle(IContainer container)
        {
            return container
                .Border(1)
                .BorderColor(Colors.Grey.Darken2)
                .Padding(5)
                .AlignMiddle();
        }

        // Header cell style
        static IContainer HeaderCellStyle(IContainer container)
        {
            return container
                .Border(1)
                .BorderColor(Colors.Black)
                .Background(Colors.Grey.Lighten3)
                .Padding(5)
                .AlignMiddle()
                .DefaultTextStyle(TextStyle.Default.Bold());
        }

        private void CheckDocumentsDirectory()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var openGymPath = System.IO.Path.Combine(documentsPath, "OpenGYM");
            var invoicesPath = System.IO.Path.Combine(openGymPath, "Invoices");
            if (!System.IO.Directory.Exists(invoicesPath))
            {
                System.IO.Directory.CreateDirectory(invoicesPath);
            }
        }

        private string GenerateInvoicePath()
        {
            if (this._membership == null || this._payment == null || this._customerID < 0 || string.IsNullOrEmpty(_customerName))
            {
                throw new InvalidOperationException("Invalid membership, payment, or customer details.");
            }

            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var openGymPath = System.IO.Path.Combine(documentsPath, "OpenGYM");
            var invoicesPath = System.IO.Path.Combine(openGymPath, "Invoices");
            return System.IO.Path.Combine(invoicesPath, $"INVOICE_M{this._membership.MembershipID}_P{this._payment.PaymentID}_C{this._customerID}_{GetDate()}.pdf");
        }

        public void SaveInvoice()
        {
            // Ensure the invoice document is generated before saving
            if (this._invoiceDocument == null)
            {
                throw new InvalidOperationException("Invoice document is not generated yet.");
            }

            // Ensure the documents directory exists
            CheckDocumentsDirectory();

            // Generate the PDF and save it to the specified path
            var invoicePath = GenerateInvoicePath();
            this._invoiceDocument.GeneratePdf(invoicePath);
        }

        public void PreviewInvoice()
        {
            // Ensure the invoice document is generated before previewing
            if (this._invoiceDocument == null)
            {
                throw new InvalidOperationException("Invoice document is not generated yet.");
            }

            // Ensure the invoice exists
            //if (!IsInvoiceSavedInDirectory())
            //{
            //    throw new InvalidOperationException("Invoice document does not exist. Please save the invoice first.");
            //}

            // Preview the invoice using QuestPDF
            this._invoiceDocument.GeneratePdfAndShow();
        }

        private bool IsInvoiceSavedInDirectory()
        {
            return System.IO.File.Exists(GenerateInvoicePath());
        }

        private string GetDate()
        {
            return DateTimeOffset.Now.ToString("yyyyMMdd");
        }

        private string GetMembershipDurationText(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                throw new ArgumentException("End date cannot be earlier than start date.");
            }

            int totalMonths = ((endDate.Year - startDate.Year) * 12) + endDate.Month - startDate.Month;
            totalMonths += endDate.Day >= startDate.Day ? 0 : -1;

            return totalMonths == 1 ? "1 شهر" : $"{totalMonths} شهور";
        }
    }
}
