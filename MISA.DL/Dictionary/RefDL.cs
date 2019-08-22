using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MISA.Entities;

namespace MISA.DL
{
    public class RefDL
    {
        private MISAWDT02NTHTrangContext db = new MISAWDT02NTHTrangContext();
        //Hàm thực hiện lấy dữ liệu data các phiếu thu
        
        public IEnumerable<Ref> GetRefData(int _pageIndex, int _pageSize)
        {
            var _employees = db.Refs.OrderBy(p => p.RefNo)
                .Skip((_pageIndex - 1) * _pageSize)
                .Take(_pageSize);
            return _employees;
        }

        //Hàm thực hiện thêm mới dữ liệu data các phiếu thu
        
        public void AddRef(Ref _ref)
        {
            _ref.RefID = Guid.NewGuid();
            db.Refs.Add(_ref);
            db.SaveChanges();
        }

        //Hàm thực hiện xóa dữ liệu phiếu thu
        
        public void DeleteRef(List<Guid> ids)
        {
            foreach (var id in ids)
            {
                var refitem = db.Refs.Where(p => p.RefID == id).FirstOrDefault();
                db.Refs.Remove(refitem);
            }
            db.SaveChanges();
        }

        //Hàm thực hiện cập nhật dữ liệu phiếu thu
        
        public void UpdateRef(Ref _ref)
        {
            var refFind = db.Refs.Where(n => n.RefID == _ref.RefID).SingleOrDefault();
            refFind.RefNo = _ref.RefNo;
            refFind.RefBirth = _ref.RefBirth;
            refFind.RefPhone = _ref.RefPhone;
            refFind.Note = _ref.Note;
            refFind.Status = _ref.Status;
            refFind.Group = _ref.Group;
            refFind.ContactName = _ref.ContactName;
            db.SaveChanges();
        }

    }
}