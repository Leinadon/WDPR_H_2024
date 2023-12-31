﻿using WPR;

public interface IUserService
{
    Task<List<User>> Get();
    Task<User?> GetById(string id);
}

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> Get()
    {
        return await _userRepository.Get();
    }

    public async Task<User?> GetById(string id)
    {
        return await _userRepository.GetById(id);
    }
}
