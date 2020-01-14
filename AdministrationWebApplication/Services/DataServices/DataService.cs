using AdministrationWebApplication.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;
using System;

namespace AdministrationWebApplication.Services.DataServices
{
    public abstract class DataService
    {
        protected DerivedDBContext _context { get; private set; }

        public DataService(DerivedDBContext context)
        {
            _context = context;
        }

        public async Task<IList<T>> GetDataAsync<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetDataById<T>(int id) where T : class
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IList<Dictionary<string, string>>> GetDataByIdTransposed<T>(int key, int numberOfColumns) where T : class
        {
            T modelData = await GetDataById<T>(key);
            Type modelTypeInformation = modelData.GetType();
            PropertyInfo[] properties = modelTypeInformation.GetProperties();

            List<Dictionary<string, string>> listOfModels = new List<Dictionary<string, string>>();
            Dictionary<string, string> modelDataTransposed = new Dictionary<string, string>();

            for (int i = 0; i < properties.Length; i++)
            {
                //when we hit x number of columns we want
                if (i != 0 && i % numberOfColumns == 0)
                {
                    //add the current dictionary with x items of data to the list
                    listOfModels.Add(modelDataTransposed);
                    //make a new dictionary for the next lot of x items
                    modelDataTransposed = new Dictionary<string, string>();
                    //begin the next set of x items with the current property
                    string propertyName = properties[i].Name == null ? "" : properties[i].Name;
                    string propertyValue = properties[i].GetValue(modelData) == null ? "" : properties[i].GetValue(modelData).ToString();
                    modelDataTransposed.Add(propertyName, propertyValue);

                    if (i == (properties.Length - 1))
                    {
                        listOfModels.Add(modelDataTransposed);
                    }
                }
                //so that the last item is added to the list even if it doesn't contain all x items
                else if (i == properties.Length - 1)
                {
                    string propertyName = properties[i].Name == null ? "" : properties[i].Name;
                    string propertyValue = properties[i].GetValue(modelData) == null ? "" : properties[i].GetValue(modelData).ToString();
                    modelDataTransposed.Add(propertyName, propertyValue);
                }
                else
                {
                    string propertyName = properties[i].Name == null ? "" : properties[i].Name;
                    string propertyValue = properties[i].GetValue(modelData) == null ? "" : properties[i].GetValue(modelData).ToString();
                    modelDataTransposed.Add(propertyName, propertyValue);
                }
            }

            return listOfModels;
        }

        public async Task<int> UpdateDataAsync<T>(IList<T> data) where T : class
        {
            _context.Set<T>().UpdateRange(data);
            return await _context.SaveChangesAsync();
        }
    }
}
