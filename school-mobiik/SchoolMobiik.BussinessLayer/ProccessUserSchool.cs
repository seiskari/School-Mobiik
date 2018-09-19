using System;
using System.Collections.Generic;
using System.Text;
using SchoolMobiik.DTOs;
using SchoolMobiik.Entity;
using SchoolMobiik.DataAccess;
using System.Security.Cryptography;

namespace SchoolMobiik.BussinessLayer
{
    public class ProccessUserSchool
    {

        public SchoolUserDTO GetUserSchool(string userName, string password)
        {
            using (var dataAccess = new SQLDataAccessSchoolUser())
            {
                SchoolUser schoolUser = dataAccess.GetSchoolUser(userName);
                if (schoolUser != null && schoolUser.Password == GetMD5(password) && schoolUser.IsActive == true)                    
                {
                    return MapEntityToDto(schoolUser);
                }
                else
                {
                    return null;
                }                  
            }
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }



        private SchoolUser MapDtoToEntity(SchoolUserDTO schoolUserDTO)
        {
            return new SchoolUser
            {
                SchoolUserId = schoolUserDTO.SchoolUserId,
                RolId = schoolUserDTO.RolId,
                UserName = schoolUserDTO.UserName,
                Password = schoolUserDTO.Password,
                IsActive = schoolUserDTO.IsActive
            };
        }

        private SchoolUserDTO MapEntityToDto(SchoolUser schoolUser)
        {
            return new SchoolUserDTO
            {
                SchoolUserId = schoolUser.SchoolUserId,
                RolId = schoolUser.RolId,
                UserName = schoolUser.UserName,
                Password = schoolUser.Password,
                IsActive = schoolUser.IsActive
            };
        }
    }
}
