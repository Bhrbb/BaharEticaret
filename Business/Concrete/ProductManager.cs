using Business.Abstract;
using Core;
using Core.Utilities;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;
        public ProductManager(IProductDal productDal)
        {
            _productdal = productDal;
        }
        public IResult Add(Product product)
        {
            _productdal.Add(product);
            return new SuccessResult("Urun Eklendi");
        }

        public IResult Delete(Product product)
        {
            _productdal.Delete(product);
            return new SuccessResult("Urun Silindi");
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productdal.GetAll(),"Urunler Listelendi");
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productdal.Get(p => p.Id == productId));
        }

        public IResult Update(Product product)
        {
            _productdal.Update(product);
            return  new SuccessResult("Urun Güncellendi");
        }
    }
}
