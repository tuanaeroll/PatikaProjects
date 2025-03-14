﻿namespace PatikaSecondDb.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }


        // relational property
        public List<PostEntity> Posts { get; set; }

    }
}
