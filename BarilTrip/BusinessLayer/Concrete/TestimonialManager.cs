﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class TestimonialManager : ITestimonialSerice
	{
		ITestimonialDal _testimonialDal;

		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}

		public void TAdd(Testimonial t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Testimonial t)
		{
			throw new NotImplementedException();
		}

		public Testimonial TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Testimonial> TGetList(Testimonial t)
		{
			return _testimonialDal.GetList();
		}

		public object TGetList()
		{
			return _testimonialDal.GetList();
		}

		public void TUpdate(Testimonial t)
		{
			throw new NotImplementedException();
		}

        List<Testimonial> IGenericService<Testimonial>.TGetList()
        {
            return _testimonialDal.GetList();
        }
    }
}
