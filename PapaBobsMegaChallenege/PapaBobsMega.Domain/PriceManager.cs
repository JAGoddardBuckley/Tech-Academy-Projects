using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobsMega.DTO;

namespace PapaBobsMega.Domain
{
    public class PriceManager
    {
        public static decimal CalculateCost(DTO.OrderDTO order)
        {
            decimal cost = 0.0M;
            var prices = getPizzaPrices();
            cost += SizeCost(order, prices);
            cost += CrustCost(order, prices);
            cost += ToppingsCost(order, prices);

            return cost;
        }

        private static decimal ToppingsCost(OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;
            cost += (order.Sausage) ? prices.SausageCost : 0M;
            cost += (order.Pepperoni) ? prices.PepperoniCost : 0M;
            cost += (order.Onions) ? prices.OnionsCost : 0M;
            cost += (order.GreenPeppers) ? prices.GreenPeppersCost : 0M;

            return cost;
         
        }

        private static decimal CrustCost(OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;
            switch (order.Crust)
            {
                case DTO.Enums.Crust.Regular:
                    cost = prices.RegularCrustCost;
                    break;
                case DTO.Enums.Crust.Thin:
                    cost = prices.ThinCrustCost;
                    break;
                case DTO.Enums.Crust.Thick:
                    cost = prices.ThickCrustCost;
                    break;
                default:
                    break;
            }
            return cost;

        }

        private static decimal SizeCost(OrderDTO order, DTO.PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;
            switch (order.Size)
            {
                case DTO.Enums.Size.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case DTO.Enums.Size.Medium:
                    cost = prices.MediumSizeCost;
                    break;
                case DTO.Enums.Size.Large:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
            }

            return cost;
        }

        private static DTO.PizzaPriceDTO getPizzaPrices()
        {
            var prices = Persistence.PizzaPriceRepository.GetPizzaPrices();

            return prices;
        }
    }
}
