// Copyright (c) 2011, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

﻿using System;
using WebsitePanel.Providers.HostedSolution;
using WebsitePanel.Providers.ResultObjects;

namespace WebsitePanel.Portal
{
    public class CRMHelper
    {
        public OrganizationUser[] GetCRMUsersPaged(int itemId,
            string filterColumn, string filterValue,
            int maximumRows, int startRowIndex, string sortColumn)
        {
            if (!String.IsNullOrEmpty(filterValue))
                filterValue = filterValue + "%";
            if (maximumRows == 0)
            {
                maximumRows = Int32.MaxValue;
            }

            string name = string.Empty;
            string email = string.Empty;

            if (filterColumn == "DisplayName")
                name = filterValue;
            else
                email = filterValue;
            

            string[] data = sortColumn.Split(' ');
            string direction = data.Length > 1 ? "DESC" : "ASC";
            OrganizationUsersPagedResult res =
                ES.Services.CRM.GetCRMUsersPaged(itemId, data[0], direction, name, email, startRowIndex, maximumRows);
            
            return res.Value.PageUsers;            
        }
        

        public int GetCRMUsersPagedCount(int itemId, string filterColumn, string filterValue)        
        {
            string name = string.Empty;
            string email = string.Empty;

            if (!string.IsNullOrEmpty(filterValue))
                filterValue = filterValue + "%";
            
            if (filterColumn == "DisplayName")
                name = filterValue;
            else            
                email = filterValue;

            IntResult res = ES.Services.CRM.GetCRMUserCount(itemId, name, email);
            return res.Value;
        }
    
    }
}
