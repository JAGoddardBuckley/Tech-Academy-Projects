using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PapaBobsMega.DTO.Enums;

namespace PapaBobsMegaChallenege.Presentation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text.Trim().Length == 0)
            {
                validLabel.Text = "Please enter a name.";
                validLabel.Visible = true;
                return;
            }
            if(addressTextBox.Text.Trim().Length ==0)
            {
                validLabel.Text = "Please enter an address.";
                validLabel.Visible = true;
                return;
            }
            if(zipTextBox.Text.Trim().Length == 0)
            {
                validLabel.Text = "Please enter a zip code.";
                validLabel.Visible = true;
                return;
            }
            if(phoneTextBox.Text.Trim().Length == 0)
            {
                validLabel.Text = "Please enter a phone number.";
                validLabel.Visible = true;
                return;
            }

            try
            {
                var order = buildOrder();
                PapaBobsMega.Domain.OrderManager.CreateOrder(order);
                Response.Redirect("success.aspx");
            }
            catch (Exception ex)
            {
                validLabel.Text = ex.Message;
                validLabel.Visible = true;
                return;
            }
        }

        private Payment determinePayment()
        {
            Payment payment;
            if (cashRadioButton.Checked)
            {
                payment = Payment.Cash;
            }
            else 
            {
                payment = Payment.Credit;
            }
            
            return payment;
        }

        private  PapaBobsMega.DTO.Enums.Size determineSize()
        {
                PapaBobsMega.DTO.Enums.Size size;
                if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("Could not determine Pizza size.");
                
            }
            return size;
        }
        private PapaBobsMega.DTO.Enums.Crust determineCrust()
        {
            PapaBobsMega.DTO.Enums.Crust crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("Could not determine Pizza crust.");
            }
            return crust;
        }
        protected void recalculateTotalCost(object sender, EventArgs e)
        {
            if (sizeDropDownList.SelectedValue == String.Empty) return;
            if (crustDropDownList.SelectedValue == String.Empty) return;
            var order = buildOrder();
            try
            {
                totalLabel.Text = PapaBobsMega.Domain.PriceManager.CalculateCost(order).ToString("C");
            }
            catch
            {
                //swallow
            }
        }
        private PapaBobsMega.DTO.OrderDTO buildOrder()
        {
            var order = new PapaBobsMega.DTO.OrderDTO();
            order.Size = determineSize();
            order.Crust = determineCrust();
            order.Sausage = sausageCheckBox.Checked;
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.GreenPeppers = peppersCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.Zip = zipTextBox.Text;
            order.Phone = phoneTextBox.Text;

            order.PaymentType = determinePayment();
            return order;
        }

    }
}