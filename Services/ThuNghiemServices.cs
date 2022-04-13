using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class ThuNghiemServices
    {
        SinhVienContext _sinhVienContext;

        public ThuNghiemServices(SinhVienContext sinhVienContext)
        {
            _sinhVienContext = sinhVienContext;
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return _sinhVienContext.SinhViens.ToList();
        }
    }
}
