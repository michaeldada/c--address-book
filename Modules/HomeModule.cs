using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;
using System.Web;
using System;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
      
