using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginsCurse.DBClasses
{
    class LoginsDB
    {
        LoginsStorageContext _context;
        private static string _master;
        public LoginsDB()
        {

            try
            {
                _master = ConfigurationManager.ConnectionStrings["master"].ConnectionString;
                CreateDataBase("LoginsStorage", @"LoginsScript\LoginsScript.sql");
                _context = new LoginsStorageContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Application exit");

                Environment.Exit(-1);
            }
        }

        public static void CreateDataBase(string dbName, string fileName)
        {
            string createDB = "USE master; " +
                $"IF(SELECT name FROM master.sys.databases WHERE name LIKE '{dbName}') IS NULL " +
                "BEGIN " +
                $"CREATE DATABASE {dbName}; " +
                "END " +
                "ELSE " +
                "ROLLBACK";

            try
            {
                using (SqlConnection connection = new SqlConnection(_master))
                {
                    using (SqlCommand command = new SqlCommand(createDB, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                using (SqlConnection connection = new SqlConnection(_master))
                {
                    using (SqlCommand command = new SqlCommand(File.ReadAllText(fileName, Encoding.Default), connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("DataBase has been created.");
                    }
                }
            }
            catch (Exception ex)
            {
                if (!ex.Message.Contains("ROLLBACK"))
                {
                    throw;
                }
            }
        }

        public List<Login> GetLogins(string name, string address, string login, string description)
        {
            return _context.Logins.AsEnumerable().Where(n => n.SitesName.SiteName.ToLower().Contains(name.ToLower()) && n.SitesAddress.SiteAddress.ToLower().Contains(address.Trim()) && n.Login1.Contains(login.Trim()) && n.Description.ToLower().Contains(description)).ToList();
        }

        public Login GetLogin(int id)
        {
            return _context.Logins.FirstOrDefault(s => s.Id == id);
        }

        public List<SitesName> GetNames()
        {
            return _context.SitesNames.AsEnumerable().ToList();
        }

        public string GetMostUsedLogin()
        {
            string login = "";
            login += _context.Logins.GroupBy(n => n.Login1).OrderByDescending(g => g.Count()).FirstOrDefault()?.Key;
            return login;
        }

        public string GetMostUsedPassword()
        {
            string password = "";
            password += _context.Logins.GroupBy(n => n.Password).OrderByDescending(g => g.Count()).FirstOrDefault()?.Key;
            return password;
        }

        public int GetMostUsedLoginCount()
        {
            int login = 0;
            login += _context.Logins.GroupBy(n => n.Login1).OrderByDescending(g => g.Count()).FirstOrDefault().Count();
            return login;
        }

        public int GetMostUsedPasswordCount()
        {
            int password = 0;
            password += _context.Logins.GroupBy(n => n.Password).OrderByDescending(g => g.Count()).FirstOrDefault().Count();
            return password;
        }

        public int GetUses(bool loginSearch, bool passwordSearch, string login, string password)
        {
            if(!loginSearch)
            {
                if(!passwordSearch)
                {
                    return 0;
                }
                else
                {
                    return _context.Logins.Where(n => n.Password == password).Count();
                }
            }
            else if(!passwordSearch)
            {
                return _context.Logins.Where(n => n.Login1 == login).Count();
            }
            else
            {
                return _context.Logins.Where(n => n.Login1 == login && n.Password == password).Count();
            }
            
        }

        public void SavePassword(Login login_entry, string name, string address, string description, string _login, string password, bool isEncrypted)
        {
            using (var dbContext = _context)
            {
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        Login login = dbContext.Logins.FirstOrDefault(d => d.Id == login_entry.Id);
                        StringBuilder warnings = new StringBuilder();
                        if (address.Trim() != "")
                        {
                            if (dbContext.SitesAddresses.FirstOrDefault(n => n.SiteAddress.ToLower() == address.Trim().ToLower()) != null)
                            {
                                login.SiteId = dbContext.SitesAddresses.FirstOrDefault(n => n.SiteAddress.ToLower() == address.Trim().ToLower()).Id;
                            }
                            else
                            {
                                SitesAddress sitesAddress = new SitesAddress() { SiteAddress = address.Trim() };
                                dbContext.SitesAddresses.Add(sitesAddress);
                                dbContext.SaveChanges();
                                login.SitesAddress = sitesAddress;
                            }
                        }
                        else
                        {
                            warnings.Append("Site address cant be empty.\n");
                        }

                        if (name.Trim() != "")
                        {
                            if (dbContext.SitesNames.FirstOrDefault(n => n.SiteName.ToLower() == name.ToLower()) != null)
                            {
                                login.SiteNameId = dbContext.SitesNames.FirstOrDefault(n => n.SiteName.ToLower() == name.ToLower()).Id;
                            }
                            else
                            {
                                SitesName sitesName = new SitesName() { SiteName = name };
                                dbContext.SitesNames.Add(sitesName);
                                dbContext.SaveChanges();
                                login.SitesName = sitesName;
                            }
                        }
                        else
                        {
                            warnings.Append("Site name cant be empty.\n");
                        }

                        login.Description = description;
                        if (_login.Trim() != "")
                        {
                            login.Login1 = _login.Trim();
                        }
                        else
                        {
                            warnings.Append("Login cant be empty.\n");
                        }

                        if (password.Trim() != "")
                        {
                            login.Password = password.Trim();
                        }
                        else
                        {
                            warnings.Append("Password cant be empty.\n");
                        }
                        login.IsEncrypted = isEncrypted;


                        if (warnings.ToString() == "")
                        {
                            dbContext.Entry(login).State = System.Data.Entity.EntityState.Modified;
                            dbContext.SaveChanges();
                            transaction.Commit();
                            MessageBox.Show("Succesful update!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(warnings.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void RemoveExtra()
        {
            try
            {
                foreach (SitesName name in _context.SitesNames)
                {
                    if(name.Logins.Count() == 0)
                    {
                        _context.SitesNames.Remove(name);
                    }
                }

                foreach (SitesAddress address in _context.SitesAddresses)
                {
                    if (address.Logins.Count() == 0)
                    {
                        _context.SitesAddresses.Remove(address);
                    }
                }

                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeletePassword(Login _login)
        {
            try
            {
                _context.Logins.Remove(_context.Logins.FirstOrDefault(n => n.Id == _login.Id));
                _context.SaveChanges();
                MessageBox.Show("Succesful removal!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddPassword(string name, string address, string description, string _login, string password, bool isEncrypted)
        {
            using (var dbContext = _context)
            {
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        Login login = new Login();
                        StringBuilder warnings = new StringBuilder();
                        if (address.Trim() != "")
                        {
                            if (dbContext.SitesAddresses.FirstOrDefault(n => n.SiteAddress.ToLower() == address.Trim().ToLower()) != null)
                            {
                                login.SiteId = dbContext.SitesAddresses.FirstOrDefault(n => n.SiteAddress.ToLower() == address.Trim().ToLower()).Id;
                            }
                            else
                            {
                                SitesAddress sitesAddress = new SitesAddress() { SiteAddress = address.Trim() };
                                dbContext.SitesAddresses.Add(sitesAddress);
                                dbContext.SaveChanges();
                                login.SitesAddress = sitesAddress;
                            }
                        }
                        else
                        {
                            warnings.Append("Site address cant be empty.\n");
                        }

                        if (name.Trim() != "")
                        {
                            if (dbContext.SitesNames.FirstOrDefault(n => n.SiteName.ToLower() == name.ToLower()) != null)
                            {
                                login.SiteNameId = dbContext.SitesNames.FirstOrDefault(n => n.SiteName.ToLower() == name.ToLower()).Id;
                            }
                            else
                            {
                                SitesName sitesName = new SitesName() { SiteName = name };
                                dbContext.SitesNames.Add(sitesName);
                                dbContext.SaveChanges();
                                login.SitesName = sitesName;
                            }
                        }
                        else
                        {
                            warnings.Append("Site name cant be empty.\n");
                        }

                        login.Description = description;
                        if (_login.Trim() != "")
                        {
                            login.Login1 = _login.Trim();
                        }
                        else
                        {
                            warnings.Append("Login cant be empty.\n");
                        }

                        if (password.Trim() != "")
                        {
                            login.Password = password.Trim();
                        }
                        else
                        {
                            warnings.Append("Password cant be empty.\n");
                        }
                        login.IsEncrypted = isEncrypted;


                        if (warnings.ToString() == "")
                        {
                            dbContext.Logins.Add(login);
                            dbContext.SaveChanges();
                            transaction.Commit();
                            MessageBox.Show("Succesful update!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(warnings.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
