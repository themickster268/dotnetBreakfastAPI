using ErrorOr;
using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfasts;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
    ErrorOr<Created> CreateBreakfast(Breakfast breakfast);

    ErrorOr<Breakfast> GetBreakfast(Guid id);

    ErrorOr<UpsertedBreakfast> UpsertBreakfast(Breakfast breakfast);

    ErrorOr<Deleted> DeleteBreakfast(Guid id);
}