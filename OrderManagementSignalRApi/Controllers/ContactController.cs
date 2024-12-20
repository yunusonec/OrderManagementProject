﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagementSignalR.BusinessLayer.Abstract;
using OrderManagementSignalR.DtoLayer.ContactDto;
using OrderManagementSignalR.EntityLayer.Entities;

namespace OrderManagementSignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                Location = createContactDto.Location,
                Mail = createContactDto.Mail,
                Phone = createContactDto.Phone,
                FooterDescription = createContactDto.FooterDescription,
                FooterTitle = createContactDto.FooterTitle,
                OpenDays = createContactDto.OpenDays,
                OpenDaysDescription = createContactDto.OpenDaysDescription,
                OpenHours = createContactDto.OpenHours,
            });
            return Ok("İletişim Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
               ContactID  = updateContactDto.ContactID,
               FooterDescription = updateContactDto.FooterDescription,
               Location = updateContactDto.Location,    
               Phone = updateContactDto.Phone,
               Mail = updateContactDto.Mail,
               FooterTitle = updateContactDto.FooterTitle,
               OpenDays = updateContactDto.OpenDays,
               OpenDaysDescription = updateContactDto.OpenDaysDescription,
               OpenHours = updateContactDto.OpenHours,
            });
            return Ok("İletişim Bilgisi Güncellendi");
        }
    }
}
