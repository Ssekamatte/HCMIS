
using HCMIS.SHARED.DTOs;

namespace HCMIS.Interface
{
    public interface IDocumentUploadService
    {
        Task UploadDocument(DocumentBytes document);
        Task<DocumentBytes?> GetDocument(string DocumentName, string DocumentFolder);
    }
}
