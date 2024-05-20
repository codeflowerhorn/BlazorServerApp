using BlazorServerApp.Models;

namespace BlazorServerApp.Client
{
    public class BookHttpClient(HttpClient http)
    {
        public async Task<bool> CreateBookAsync(BookModel book)
        {
            var response = await http.PostAsJsonAsync(http.BaseAddress + "/Book", book);
            return response.IsSuccessStatusCode;
        }
        public async Task<IEnumerable<BookModel>> GetBooksAsync()
        {
            return await http.GetFromJsonAsync<IEnumerable<BookModel>>(http.BaseAddress + "/Book") ?? [];
        }

        public async Task<BookModel> GetBookAsync(int id)
        {
            return await http.GetFromJsonAsync<BookModel>(http.BaseAddress + "/Book/id=" + id) ?? null;
        }

        public async Task<bool> UpdateBookAsync(BookModel book)
        {
            var response = await http.PutAsJsonAsync(http.BaseAddress + "/Book", book);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var response = await http.DeleteAsync(http.BaseAddress + "/Book/id=" + id);
            return response.IsSuccessStatusCode;
        }
    }
}