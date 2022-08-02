using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
   [Authorize]
    public class UsersController : BaseApiController
    {
        public IUserRepository _userRespository { get; }
        public IMapper _mapper { get; }
        
        public UsersController(IUserRepository userRespository, IMapper mapper)
        {
            _mapper = mapper;
            _userRespository = userRespository;
            
        }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers(){
        var users = await _userRespository.GetMembersAsync();

        return Ok(users);
    }
    
    [HttpGet("{username}")]
    public async Task<ActionResult<MemberDto>> GetUser(string username){

        return await _userRespository.GetMemberAsync(username);
        
    }

    }
}