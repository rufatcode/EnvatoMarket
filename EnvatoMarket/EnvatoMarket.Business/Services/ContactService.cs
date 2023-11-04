using System;
using System.Linq.Expressions;
using EnvatoMarket.Business.Interfaces;
using EnvatoMarket.Core.Interfaces;
using EnvatoMarket.Core.Models;
using EnvatoMarket.Data.Implimentations;

namespace EnvatoMarket.Business.Services
{
	public class ContactService:IContactService
	{
        private readonly IContactRepository _contactRepository;
		public ContactService(IContactRepository contactRepository)
		{
            _contactRepository = contactRepository;
		}

        public async Task<bool> Create(Contact entity)
        {
            try
            {
                
                await _contactRepository.Create(entity);
                await _contactRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                if (!await IsExist(c => c.Id == id))
                {
                    return false;
                }
                Contact contact = await GetEntity(c => c.Id == id);
                if (contact.IsDeleted)
                {
                    return false;
                }
                List<Contact> contacts = await GetAll();
                if (contacts.Where(c => c.Id != id).All(c => c.IsDeleted))
                {
                    return false;
                }
                contact.IsDeleted = true;
                contact.Removed = DateTime.Now;
                await _contactRepository.Update(contact);
                await _contactRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<List<Contact>> GetAll(Expression<Func<Contact, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _contactRepository.GetAll(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<Contact> GetEntity(Expression<Func<Contact, bool>> predicate = null, params string[] includes)
        {
            try
            {
                return await _contactRepository.GetEntity(predicate, includes);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> IsExist(Expression<Func<Contact, bool>> predicate = null)
        {
            try
            {
                return await _contactRepository.IsExist(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }

        public async Task<bool> Update(Contact entity)
        {
            try
            {
                entity.Updated = DateTime.Now;
                if (!entity.IsDeleted)
                {
                    entity.Removed = null;
                }
                List<Contact> contacts = await GetAll();
                if (contacts.Where(c => c.Id != entity.Id).All(c => c.IsDeleted))
                {
                    if (entity.IsDeleted)
                    {
                        return false;
                    }

                }
                await _contactRepository.Update(entity);
                await _contactRepository.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("something went wrong");
            }
        }
    }
}

