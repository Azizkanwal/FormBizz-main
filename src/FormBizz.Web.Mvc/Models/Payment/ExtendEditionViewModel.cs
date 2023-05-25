﻿using System.Collections.Generic;
using FormBizz.Editions.Dto;
using FormBizz.MultiTenancy.Payments;

namespace FormBizz.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}