"""Point d'entrée"""

# l'utilisation de pprint permet de mieux afficher les conteneurs.
from pprint import pprint

from films.library import Library

def main():
    """Code client."""
    library = Library()

    films = library.films

    print("Tous mes films:")
    pprint(films)

if __name__ == "__main__":
    main()
