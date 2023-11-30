using Blazored.Toast.Services;
using HCMIS.Interface;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.DTO;
using System.Numerics;
using System.Text.Json;

namespace HCMIS.Repository
{
    public class DocumentUploadService : IDocumentUploadService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        private readonly IToastService toastService;
        public DocumentUploadService(HttpClient httpClient, IToastService toastService)
        {
            _httpClient = httpClient;
            this.toastService = toastService;
        }
        public async Task<DocumentBytes?> GetDocument(string DocumentName, string DocumentFolder)
        {
            DocumentBytes? data = new DocumentBytes();
            try
            {
                var response = await _httpClient.GetAsync($"DocumentUpload/GetDocument?DocumentName={DocumentName}&DocumentFolder={DocumentFolder}");
                var content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    data = JsonSerializer.Deserialize<DocumentBytes>(content, _options);
                }
                else
                {
                    toastService.ShowError(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
            return data;
        }

        public async Task UploadDocument(DocumentBytes document)
        {
            try
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(document);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var result = await _httpClient.PostAsync($"DocumentUpload/UploadDocument", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<Response>(content, _options);
                    if (data != null)
                    {
                        if (data.IsSuccess == true)
                        {
                            toastService.ShowSuccess(data.Message);
                        }
                        else
                        {
                            toastService.ShowError(data.Message);
                        }
                    }
                }
                else
                {
                    toastService.ShowError(result.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
        }
    }
}
