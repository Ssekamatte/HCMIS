


using HCMIS.SHARED.Data;
using HCMIS.SHARED.DTO;

namespace HCMIS.Interface
{
    public interface IDocumentUploadService
    {
        Task UploadDocument(DocumentBytes document);
        Task<DocumentBytes?> GetDocument(string DocumentName, string DocumentFolder);
    }
}
