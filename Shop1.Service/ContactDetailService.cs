﻿using Shop1.Data.Infrastructure;
using Shop1.Data.Repositories;
using Shop1.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop1.Service
{
    public interface IContactDetailService
    {
        ContactDetail GetDefaultContact();
    }
    public class ContactDetailService: IContactDetailService
    {
        IContactDetailRepository _contactDetailRepository;
        IUnitOfWork _unitOfWork;
        public ContactDetailService(IContactDetailRepository contactDetailRepository, IUnitOfWork unitOfWork)
        {
            this._contactDetailRepository = contactDetailRepository;
            this._unitOfWork = unitOfWork;
        }

        public ContactDetail GetDefaultContact()
        {
            return _contactDetailRepository.GetSingleByCondition(x => x.Status);
        }
    }
}
