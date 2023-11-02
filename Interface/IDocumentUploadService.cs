


using HCMIS.SHARED.Data;

namespace HCMIS.Interface
{
    public interface IDocumentUploadService
    {
        Task UploadDocument(DocumentBytes document);
        Task<DocumentBytes?> GetDocument(string DocumentName, string DocumentFolder);
    }
}
