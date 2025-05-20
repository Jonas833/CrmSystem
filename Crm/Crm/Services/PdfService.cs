using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Crm.Services
{
    public class PdfService
    {
        public byte[] GenerateSimplePdf()
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Content().Column(column =>
                    {
                        column.Item().Text("Hallo Welt!").Bold();
                        column.Item().Text("Dies ist ein gültiges PDF mit QuestPDF.");
                        column.Item().Text("Erstellt am: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                    });
                });
            });

            return document.GeneratePdf();
        }
    }
}

