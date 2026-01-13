using Dars2._3.Models;

namespace Dars2._3.Services;

internal class PhoneService
{
    List<Phone> Phones;
    public PhoneService()
    {
        Phones = new List<Phone>();
    }
    public List<Phone> GetAllPhones()
    {
        return Phones;
    }
    public Phone? GetPhoneById(Guid phoneId)
    {
        foreach (var p in Phones)
        {
            if (p.PhoneId == phoneId) return p;
        }
        return null;
    }
    public Guid AddPhone(Phone phone)
    {
        phone.PhoneId = Guid.NewGuid();
        Phones.Add(phone);
        return phone.PhoneId;
    }
    public bool UpdatePhone(Guid phoneId, Phone newPhone)
    {
        for (var i = 0; i < Phones.Count; i++)
        {
            if (Phones[i].PhoneId == phoneId)
            {
                Phones[i].ScreenSize = newPhone.ScreenSize;
                Phones[i].StorageGb = newPhone.StorageGb;
                Phones[i].RamGb = newPhone.RamGb;
                Phones[i].Brand = newPhone.Brand;
                Phones[i].Price = newPhone.Price;
                Phones[i].Model = newPhone.Model;
                return true;
            }
        }
        return false;
    }
    public bool DeletePhone(Guid phoneId)
    {
        foreach (var p in Phones)
        {
            if (phoneId == p.PhoneId)
            {
                Phones.Remove(p);
                return true;
            }
        }
        return false;
    }

}
