using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            //Business Rules

            //AutoMapper
            Brand brand = new Brand();
            brand.Name = createBrandRequest.Name;
            brand.CreatedDate = DateTime.Now;

            _brandDal.Add(brand);

            CreatedBrandResponse createBrandResponse = new CreatedBrandResponse();
            createBrandResponse.Name = brand.Name;
            createBrandResponse.Id = 4;
            createBrandResponse.CreatedDate = brand.CreatedDate;

            return createBrandResponse;
        }

        public List<GetAllBradResponse> GetAll()
        {
            List<Brand> brands = _brandDal.GetAll();

            List<GetAllBradResponse> getAllBradResponses = new List<GetAllBradResponse>();

            foreach (var brand in brands)
            {
                GetAllBradResponse getAllBradResponse = new GetAllBradResponse();
                getAllBradResponse.Name = brand.Name;
                getAllBradResponse.Id = brand.Id;
                getAllBradResponse.CreatedDate = brand.CreatedDate;

                getAllBradResponses.Add(getAllBradResponse);
            }

            return getAllBradResponses;
        }
    }
}
