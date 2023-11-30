using Blazored.Toast.Services;
using HCMIS.Data;
using HCMIS.Model;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.DTO;
using System.Net.Http.Headers;
using System.Text.Json;

namespace HCMIS.ViewModel
{
    public class DocumentUploadModel
    {
        private readonly ApiConfig _ApiConfig;
        private readonly HttpClient _httpClient;
        private readonly IToastService toastService;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public DocumentUploadModel(ApiConfig apiConfig,
            HttpClient http, IToastService toastService)
        {
            this._ApiConfig = apiConfig;
            this._httpClient = http;
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
                    toastService.ClearAll(); toastService.ShowError(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                toastService.ClearAll(); toastService.ShowError(ex.Message);
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
                            toastService.ClearAll(); toastService.ShowSuccess(data.Message);
                        }
                        else
                        {
                            toastService.ClearAll(); toastService.ShowError(data.Message);
                        }
                    }
                }
                else
                {
                    toastService.ClearAll(); toastService.ShowError(result.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                toastService.ClearAll(); toastService.ShowError(ex.Message);
            }
        }

        //public async Task<Response> SaveDocument(ImageUpload inputmodel, string? AccessToken)
        //{
        //    Response? _response = new();
        //    try
        //    {
        //        string json = Newtonsoft.Json.JsonConvert.SerializeObject(inputmodel);
        //        StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

        //        var result = await Http.PostAsync($"NonStaff/SaveDocumentUpload", httpContent);
        //        if (result.IsSuccessStatusCode)
        //        {
        //            var content = await result.Content.ReadAsStringAsync();
        //            _response = JsonSerializer.Deserialize<Response>(content, _options);
        //        }
        //        else
        //        {
        //            _response= new();
        //            _response.IsSuccess = false;
        //            _response.Message = $"Error: {result.ReasonPhrase}";
        //            _response.Status = "Error";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _response = new();
        //        _response.IsSuccess = false;
        //        _response.Message = $"Error: {ex.Message}";
        //        _response.Status = "Error";
        //    }
        //    return _response;
        //}
        //public async Task<ImageUpload> GetDocument(string? DocName, string? Rootfolder, string? AccessToken)
        //{
        //    ImageUpload? imageUpload = new();
        //    try
        //    {
        //        var response = await Http.GetAsync($"NonStaff/DocumentUpload/{DocName}/{Rootfolder}");
        //        var content = await response.Content.ReadAsStringAsync();
        //        if (response.IsSuccessStatusCode)
        //        {
        //            imageUpload = JsonSerializer.Deserialize<ImageUpload>(content, _options);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    return imageUpload;
        //}
    }
}
