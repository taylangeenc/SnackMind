using FluentValidation;

using SnackMindDTOs.DTOs.Reservation.Reservation.Reservation;

using System;

namespace SnackMindApp.Validation.Reservation.Reservation
{
    public class vldCreateReservation : AbstractValidator<dtoCreateReservation>
    {
        public vldCreateReservation()
        {
            RuleFor(x => x.GuestCount)
                .GreaterThan(0).WithMessage("Misafir sayısı sıfırdan büyük olmalıdır.");

            RuleFor(x => x.ReservedDate)
                .GreaterThan(DateTime.UtcNow).WithMessage("Rezervasyon tarihi ileri bir tarih olmalıdır.");

            RuleFor(x => x.TableRef)
                .NotEmpty().WithMessage("Masa referansı boş olamaz.");

            RuleFor(x => x.CustomerRef)
                .NotEmpty().WithMessage("Müşteri referansı boş olamaz.");

            RuleFor(x => x.ReservationStateRef)
                .NotEmpty().WithMessage("Rezervasyon durumu referansı boş olamaz.");
        }
    }
}