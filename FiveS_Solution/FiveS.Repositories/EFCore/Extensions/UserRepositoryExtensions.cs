using FiveS.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;


namespace FiveS.Repositories.EFCore.Extensions
{
    public static class UserRepositoryExtensions
    {
        public static IQueryable<User> FilterBooks(this IQueryable<User> users,
            uint minPrice, uint maxPrice)
        {
            return users;
            //return users.Where(book =>
            //   book.Price >= minPrice &&
            //   book.Price <= maxPrice);
        }

        public static IQueryable<User> Search(this IQueryable<User> users,
            string searchTerm)
        {
            if (String.IsNullOrWhiteSpace(searchTerm))
                return users;

            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return users
                .Where(user => user.UserName
                .ToLower().Contains(searchTerm));
        }

        public static IQueryable<User> Sort(this IQueryable<User> users,
            string orderByQueryString)
        {
            if (String.IsNullOrWhiteSpace(orderByQueryString))
                return users.OrderBy(b => b.Id);

            var orderQuery = OrderQueryBuilder
                .CreateOrderQuery<User>(orderByQueryString);

            if (orderQuery is null)
                return users.OrderBy(b => b.Id);

            return users.OrderBy(orderQuery);
        }
    }
}
