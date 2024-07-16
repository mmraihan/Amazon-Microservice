using Amazon.Services.CouponAPI.Data;
using Amazon.Services.CouponAPI.Dtos;
using Amazon.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Services.CouponAPI.Controllers
{

    public class CouponAPIController : BaseAPIController
    {

        private readonly AppDbContext _db;
        private ResponseDto _response;

        public CouponAPIController(AppDbContext db, ResponseDto response)
        {
            _db = db;
            _response = response;
        }

        //[HttpGet]

        //public ResponseDto Get()
        //{
        //    try
        //    {
        //        var couponList = _db.Coupons.ToList();
        //        _response.Result = couponList;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

       
    }
}
