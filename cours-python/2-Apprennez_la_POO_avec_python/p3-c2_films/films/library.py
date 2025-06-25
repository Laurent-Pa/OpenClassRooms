"""Définit la bibliothèque virtuelle"""

from .film import FilmCleaner
from .data import films

class Library:
    """Bibliothèque de films."""

    def __init__(self):
        """Initialise les films."""
        self.films = []
        for film_data in films:
            film = FilmCleaner(film_data).generate()
            film.where = self
            self.films.append(film)

        # self.sort_by_date_and_name()

def sort_by_date_and_name(self):
        """Tri les films par date et par nom."""
        self.films.sort(key=lambda film: (film.date, film.name))
