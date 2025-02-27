﻿using DataAcessDemo.API.Models;

namespace DataAcessDemo.API.Repositories;

public interface IUserRepository
{
	public List<User> Get();
	public User Get(int id);
	public void Insert(User user);
	public void Update(User user);
	public void Delete(int id);

}
