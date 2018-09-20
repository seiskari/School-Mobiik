using SchoolMobiik.DTOs;
using SchoolMobiik.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolMobiik.BussinessLayer
{
  public class ProccessUserRegister
    {


        private Person MapDtoToEntityPerson(UserRegisterDTO userRegisterDTO)
        {
            return new Person
            {
                Birthday = userRegisterDTO.Birthday,
                Curp = userRegisterDTO.CURP,
                Phone = userRegisterDTO.Phone,
                Email = userRegisterDTO.Email,
                PersonFirstName = userRegisterDTO.FirstName,
                PersonLastName = userRegisterDTO.LastName + "_"+ userRegisterDTO.SecondLastName
            };
        }
        private SchoolUser MapDtoToEntitySchoolUser(UserRegisterDTO userRegisterDTO)
        {
            return new SchoolUser
            {
                UserName = userRegisterDTO.UserName,
                Password = userRegisterDTO.Password
            };
        }
        private Address MapDtoToEntityAddress(UserRegisterDTO userRegisterDTO)
        {
            return new Address
            {
                Street = userRegisterDTO.Street,
                Neighborhood = userRegisterDTO.Neighborhood,
                ExtNum = userRegisterDTO.ExtNum,
                IntNum = userRegisterDTO.IntNum
            };
        }

        private UserRegisterDTO MapEntityToDtoPerson( Person person)
        {
            string LastNameSub,SecondLastNameSub;
            int IndexOf;
            IndexOf = person.PersonLastName.IndexOf("_");
            LastNameSub = person.PersonLastName.Substring(0,IndexOf);
            SecondLastNameSub = person.PersonLastName.Substring((IndexOf + 1), (person.PersonLastName.Length-IndexOf-1));
            return new UserRegisterDTO
            {
                Birthday = person.Birthday,
                CURP = person.Curp,
                Phone = person.Phone,
                Email = person.Email,
                FirstName = person.PersonFirstName,
                LastName = LastNameSub,
                SecondLastName = SecondLastNameSub               
            };
        }
        private UserRegisterDTO MapEntityToDtoSchoolUser(SchoolUser schoolUser)
        {
            return new UserRegisterDTO
            {
                UserName = schoolUser.UserName,
                Password = schoolUser.Password
            };
        }
        private UserRegisterDTO MapEntityToDtoAddress(Address address)
        {
            return new UserRegisterDTO
            {
                Street = address.Street,
                Neighborhood = address.Neighborhood,
                ExtNum = address.ExtNum,
                IntNum = address.IntNum
            };
        }
    }
}
