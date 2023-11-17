using RestWithASPNETErudio.Data.VO;
using RestWithASPNETErudio.Hypermedia.Utils;

namespace RestWithASPNETErudio.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        PagedSearchVO<BookVO> FindWithPagedSearch(
            string title, string sortDirection, int pageSize, int page);
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
