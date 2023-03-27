import { useState } from "react";
import axios from "axios";

const ReservationForm = ({ room, onSubmit }) => {
  const [dateFrom, setDateFrom] = useState("");
  const [dateTo, setDateTo] = useState("");
  const [reservedPeople, setReservedPeople] = useState("");
  const [isLoading, setIsLoading] = useState(false);
  const [message, setMessage] = useState("");

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (!dateFrom || !dateTo || !reservedPeople) {
      setMessage("Please fill in all the fields");
      return;
    }

    setIsLoading(true);
    try {
      const response = await axios.post(
        "https://localhost:7095/api/reservations",
        {
          roomId: room.id,
          dateFrom,
          dateTo,
          reservedPeople,
        }
      );
      setMessage("Reservation created successfully!");
      setDateFrom("");
      setDateTo("");
      setReservedPeople("");
      onSubmit(response.data);
    } catch (error) {
      console.log(error.response);
      setMessage(error.response.data || "Something went wrong");
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <form className="reservation-form" onSubmit={handleSubmit}>
      <h3>{room.name}</h3>
      <div className="form-field">
        <label htmlFor="dateFrom">Date From</label>
        <input
          type="date"
          id="dateFrom"
          value={dateFrom}
          onChange={(e) => setDateFrom(e.target.value)}
        />
      </div>
      <div className="form-field">
        <label htmlFor="dateTo">Date To</label>
        <input
          type="date"
          id="dateTo"
          value={dateTo}
          onChange={(e) => setDateTo(e.target.value)}
        />
      </div>
      <div className="form-field">
        <label htmlFor="reservedPeople">Reserved People</label>
        <input
          type="number"
          min="1"
          value={reservedPeople}
          onChange={(e) => setReservedPeople(parseInt(e.target.value))}
        />
      </div>
      <button className="form-submit-btn" type="submit" disabled={isLoading}>
        {isLoading ? "Loading..." : "Submit"}
      </button>
      {message && <div className="form-message">{message}</div>}
    </form>
  );
};

export default ReservationForm;
