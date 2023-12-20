import { showAllDoctorsActions } from "../store/showAllDoctors";

export const fetchDoctors = () => {
  return async (dispatch) => {
    const fetchData = async () => {
      const response = await fetch(
        "https://localhost:7052/doctors?PageNumber=1&PageSize=30"
      );

      if (!response.ok) {
        throw new Error("Coś poszło nie tak");
      }

      const data = await response.json();

      return data;
    };

    try {
      const doctorsData = await fetchData();
      console.log(doctorsData);
      dispatchEvent(showAllDoctorsActions.changeItems(doctorsData));
    } catch (error) {
      console.error("Błąd podczas pobierania danych:", error);
    }
  };
};
