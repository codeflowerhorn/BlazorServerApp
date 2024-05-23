using BlazorServerApp.Models;

namespace BlazorServerApp.Client
{
    public class BookHttpClient(HttpClient http)
    {
        public async Task<bool> CreateBookAsync(BookModel book)
        {
            var response = await http.PostAsJsonAsync("/api/book", book);
            return response.IsSuccessStatusCode;
        }
        public async Task<IEnumerable<BookModel>> GetBooksAsync()
        {
            return await http.GetFromJsonAsync<IEnumerable<BookModel>>("/api/book") ?? [];
        }

        public async Task<BookModel> GetBookAsync(int id)
        {
            return await http.GetFromJsonAsync<BookModel>("/api/book/id=" + id) ?? new BookModel();
        }

        public async Task<bool> UpdateBookAsync(BookModel book)
        {
            var response = await http.PutAsJsonAsync("/api/book", book);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var response = await http.DeleteAsync("/api/book/id=" + id);
            return response.IsSuccessStatusCode;
        }
    }
}