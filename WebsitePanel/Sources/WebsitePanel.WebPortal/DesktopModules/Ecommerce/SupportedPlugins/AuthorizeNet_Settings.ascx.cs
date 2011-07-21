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

using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using WebsitePanel.Ecommerce.EnterpriseServer;

namespace WebsitePanel.Ecommerce.Portal.SupportedPlugins
{
	public partial class AuthorizeNet_Settings : ecControlBase, IPluginProperties
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		#region IPluginSettings Members

		public KeyValueBunch Properties
		{
			get { return GetPluginProperties(); }
			set { SetPluginProperties(value); }
		}

		#endregion

		private void SetPluginProperties(KeyValueBunch settings)
		{
			// set demo account
			chkDemoAccount.Checked = ecUtils.ParseBoolean(settings[AuthNetSettings.DEMO_ACCOUNT], false);
			// set merchant email
			txtMerchantEmail.Text = settings[AuthNetSettings.MERCHANT_EMAIL];
			// set live mode
			chkLiveModeEnabled.Checked = ecUtils.ParseBoolean(settings[AuthNetSettings.LIVE_MODE], false);
			// set send confirmation
			chkSendConfirmation.Checked = ecUtils.ParseBoolean(settings[AuthNetSettings.SEND_CONFIRMATION], false);
			//
			txtMd5Hash.Text = settings[AuthNetSettings.MD5_HASH];
			//
			txtAccount.Text = settings[AuthNetSettings.USERNAME];
			//
			txtTransKey.Text = settings[AuthNetSettings.TRANSACTION_KEY];
		}

		private KeyValueBunch GetPluginProperties()
		{
			KeyValueBunch bunch = new KeyValueBunch();
			//
			// set demo account
			bunch[AuthNetSettings.DEMO_ACCOUNT] = chkDemoAccount.Checked.ToString();
			// set merchant email
			bunch[AuthNetSettings.MERCHANT_EMAIL] = txtMerchantEmail.Text.Trim();
			// set live mode
			bunch[AuthNetSettings.LIVE_MODE] = chkLiveModeEnabled.Checked.ToString();
			// set send confirmation
			bunch[AuthNetSettings.SEND_CONFIRMATION] = chkSendConfirmation.Checked.ToString();
			//
			bunch[AuthNetSettings.MD5_HASH] = txtMd5Hash.Text.Trim();
			//
			bunch[AuthNetSettings.USERNAME] = txtAccount.Text.Trim();
			//
			bunch[AuthNetSettings.TRANSACTION_KEY] = txtTransKey.Text.Trim();
			//
			return bunch;
		}
	}
}