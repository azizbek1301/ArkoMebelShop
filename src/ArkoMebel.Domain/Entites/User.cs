﻿namespace ArkoMebel.Domain.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string FullName {  get; set; }
        public string Email { get; set; }
        public string PasswordHash{ get; set; }
        public string PhoneNumber {  get; set; }
        public string RefreshToken {  get; set; }   

    }
}
