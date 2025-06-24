"""Définit les amis"""

class Friend:
    """Ami."""

    def __init__(self, name, film=None):
        """Initialise le nom, et un film prêté si c'est le cas."""
        self.name = name
        self.film = film
        if film:
            film.where = self

    def __str__(self):
        return f"{self.name}"

    def __repr__(self):
        return self.__str__()
